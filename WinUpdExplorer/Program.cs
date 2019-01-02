using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using WinUpdExplorer.CixManifest;

namespace WinUpdExplorer
{
    public static partial class Program
    {
        public static int Main(string[] args)
        {
            Initialize();
            // bool allConjectureStand = WsusScanParallelContentConjecture(); // UNUSED
            // Read the package.xml file from WSUSSCAN directory.
            ReadPackage(); // Disconnected for tests speed-up

            // Build inter Update dependencies from package content.
            //UpdateDependencyManager dependencyManager = new UpdateDependencyManager(_package);
            //dependencyManager.BuildDependencies(); // Disconnected for tests speed-up

            // Build updates details from the content of the core, extended and localized
            // sub-directories of WSUSSCAN.
            // ReadUpdatesDetails(); // Disconnected for tests speed-up

            ReadMainManifest();
            // DisplayMainManifestStatistics();
            LoadPSFXManifests();
            return 0;
        }

        private static XmlSerializer CreateStandardSerializer<T>()
        {
            XmlSerializer result = new XmlSerializer(typeof(T));
            result.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                TraceUnknownNode(e);
                return;
            });
            result.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                TraceUnknownAttribute(e);
                return;
            });
            return result;
        }

        private static void DisplayMainManifestStatistics()
        {
            Dictionary<string, Dictionary<UpdateItemFamily, List<string>>> perArchitectureUpdateFamilies =
                new Dictionary<string, Dictionary<UpdateItemFamily, List<string>>>();
            UpdateItemFamily searchedItem = new UpdateItemFamily();
            uint totalAdditions = 0;
            foreach (FileDescriptor descriptor in _manifest.Files) {
                descriptor.ParseFileName();
                if (descriptor.IsCatalog) {
                    // Ignore catalog files.
                    continue;
                }
                if (descriptor.IsMum) {
                    // Ignore mum files.
                    continue;
                }
                string architecture = descriptor.Architecture;
                Dictionary<UpdateItemFamily, List<string>> targetArchitectureCollection;
                if (!perArchitectureUpdateFamilies.TryGetValue(architecture, out targetArchitectureCollection)) {
                    targetArchitectureCollection = new Dictionary<UpdateItemFamily, List<string>>(UpdateItemFamily.Comparer);
                    perArchitectureUpdateFamilies.Add(architecture, targetArchitectureCollection);
                }
                searchedItem.Initialize(descriptor);
                List<string> languages;
                if (!targetArchitectureCollection.TryGetValue(searchedItem, out languages)) {
                    languages = new List<string>();
                    targetArchitectureCollection.Add((UpdateItemFamily)searchedItem.Clone(), languages);
                }
                string candidateLanguage = descriptor.Language;
                if (!languages.Contains(candidateLanguage)) {
                    totalAdditions++;
                    languages.Add(candidateLanguage);
                }
            }
            // Often a given item aggregates several files. Thus the dsplayed items count should be
            // expected to be significantly lower than the descriptors count from the _manifest member.
            // Combined language customization * files per descriptor can lead to 1/3 to 1/10 ratio.
            Console.WriteLine("{0} items", totalAdditions);
            foreach (KeyValuePair<string, Dictionary<UpdateItemFamily, List<string>>> pair in perArchitectureUpdateFamilies) {
                Console.WriteLine(pair.Key);
                foreach(KeyValuePair<UpdateItemFamily, List<string>> update in pair.Value) {
                    Console.WriteLine("\t{0}v{1} #{2}", update.Key.SyntheticName, update.Key.Version, update.Value.Count);
                }
            }
            return;
        }

        // TODO : Merge this with XmlFragmentSerializationWrapper::DumpContent method.
        private static void DumpContent(this FileStream from, int startPosition = 0, int length = -1)
        {
            // Cap length otherwise we may miss the error messages.
            if (-1 == length) {
                length = (int)Math.Min(8000 * 80, from.Length);
            }
            byte[] buffer = new byte[length + 1024];
            from.Position = 0;
            int readCount = from.Read(buffer, 0, (-1 == length) ? buffer.Length : length);
            string content = Encoding.UTF8.GetString(buffer, startPosition, readCount);
            Console.WriteLine("============================");
            Console.WriteLine(content);
            Console.WriteLine("============================");
        }

        private static void Initialize()
        {
            _baseDirectory = new DirectoryInfo(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Temp", "WinUpdate20181212"));
            _packageDirectory = new DirectoryInfo(Path.Combine(_baseDirectory.FullName, "PACKAGE"));
            _psfxDirectory = new DirectoryInfo(Path.Combine(_baseDirectory.FullName, "PSFX"));
            _wsusscanDirectory = new DirectoryInfo(Path.Combine(_baseDirectory.FullName, "WSUSSCAN"));
        }

        private static XmlSerializer FindRelevantSerializer(FileStream from, XmlSerializer asmV1Serializer,
            XmlSerializer asmV3Serializer)
        {
            byte[] buffer = new byte[1024];
            try { from.Read(buffer, 0, buffer.Length); }
            finally { from.Position = 0; }
            // TODO : Unsafe in case of multibyte encoding.
            string data = Encoding.UTF8.GetString(buffer);
            return (-1 != data.IndexOf(Manifest.XmlNamespaces.AssemblyV1))
                ? asmV1Serializer
                : asmV3Serializer;
        }

        private static void LoadPSFXManifests()
        {
            XmlSerializer asmV1Serializer = CreateStandardSerializer<Manifest.AsmV1Assembly>();
            XmlSerializer asmV3Serializer = CreateStandardSerializer<Manifest.AsmV3Assembly>();
            int ignoredCount = 0;
            int failureCount = 0;
            int successCount = 0;
            foreach (FileInfo candidate in _psfxDirectory.GetFiles("*.manifest")) {
                using (FileStream input = File.OpenRead(candidate.FullName)) {
                    try {
                        XmlSerializer targetSerializer = FindRelevantSerializer(input, asmV1Serializer, asmV3Serializer);
                        if (object.ReferenceEquals(targetSerializer, asmV3Serializer)) {
                            continue;
                        }
                        // TODO : Find a way to disambiguate ahead of time the appropriate version and
                        // the relevant serializer.
                        Manifest.AssemblyBase assemblyManifest = (Manifest.AssemblyBase)targetSerializer.Deserialize(input);
                        if (_xmlParsingErrorEncountered) {
                            Console.WriteLine("{0} files succeeded", successCount);
                            input.DumpContent();
                            int i = 1;
                        }
                        //if (null != assemblyManifest.Dependency) {
                        //    foreach(Manifest.Dependency scannedDependency in assemblyManifest.Dependency) {
                        //        string discoverable = scannedDependency.Discoverable;
                        //        if (("no" != discoverable) && ("false" != discoverable)) {
                        //            throw new NotImplementedException();
                        //        }
                        //    }
                        //}
                        successCount++;
                    }
                    catch (Exception e) {
                        // TODO : These are file using the "urn:schemas-microsoft-com:asm.v1" namespace.
                        Exception scannedException;
                        for (scannedException = e;
                            null != scannedException.InnerException;
                            scannedException = scannedException.InnerException) ;
                        if (!scannedException.Message.StartsWith("<assembly xmlns='urn:schemas-microsoft-com:asm.v3'>")) {
                            Console.WriteLine(scannedException.Message);
                            failureCount++;
                        }
                        else {
                            ignoredCount++;
                        }
                    }
                }
            }
            return;
        }

        private static void ReadMainManifest()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Container));
            int firstErrorPosition = -1;
            int errorsCount = 0;
            serializer.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                if (10 > errorsCount++) {
                    TraceUnknownNode(e);
                    if (0 > firstErrorPosition) {
                        firstErrorPosition = e.LinePosition;
                    }
                }
                return;
            });
            serializer.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                if (10 > errorsCount++) {
                    TraceUnknownAttribute(e);
                    if (0 > firstErrorPosition) {
                        firstErrorPosition = e.LinePosition;
                    }
                }
                return;
            });
            using (FileStream input = File.OpenRead(Path.Combine(_psfxDirectory.FullName, "_manifest_.cix.xml"))) {
                _manifest = (Container)serializer.Deserialize(input);
                if (0 <= firstErrorPosition) {
                    byte[] buffer = new byte[2048];
                    input.Seek(Math.Max(0, firstErrorPosition - 400), SeekOrigin.Begin);
                    int readCount = input.Read(buffer, 0, buffer.Length);
                    Console.WriteLine("At C{0} == see 6th line =======================", firstErrorPosition);
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, readCount));
                    Console.WriteLine("=========================");
                }
                else {
                    Console.WriteLine("{0} files in base manifest", _manifest.Files.Length);
                    foreach(FileDescriptor descriptor in _manifest.Files) {
                        if (null == descriptor.Delta) { int k = 1; }
                        if (null == descriptor.Delta.Basis) {
                            if ("PA30" == descriptor.Delta.Source.Type) { int z = 1; }
                        }
                        else {
                            if (null == descriptor.Delta.Source) { int i = 1; }
                            else if ("PA30" != descriptor.Delta.Source.Type) { int j = 1; }
                        }
                    }
                }
            }
            return;
        }

        private static void ReadPackage()
        {
            XmlSerializer serializer = CreateStandardSerializer<Packaging.Package>();
            using (FileStream input = File.OpenRead(Path.Combine(_wsusscanDirectory.FullName, "package.xml"))) {
                _package = (Packaging.Package)serializer.Deserialize(input);
            }
            return;
        }

        private static void ReadUpdatesDetails()
        {
            DirectoryInfo coreDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "core"));
            DirectoryInfo extendedDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "extended"));
            DirectoryInfo localizedDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "localized"));

            XmlSerializer coreSerializer = CreateStandardSerializer<Scanning.Core.UpdateCoreDetails>();
            XmlSerializer extendedSerializer = CreateStandardSerializer<Scanning.Extended.UpdateExtendedDetails>();
            foreach (uint updateId in _package.EnumerateUpdateIds()) {
                if (2858 == updateId) { continue; }
                Scanning.Core.UpdateCoreDetails coreDetails =
                    ReadWSUSScanUpdateDetails<Scanning.Core.UpdateCoreDetails>(coreSerializer, coreDirectory,
                        updateId, Scanning.Core.UpdateCoreDetails.RootNodeName);
                Scanning.Extended.UpdateExtendedDetails extendedDetails =
                    ReadWSUSScanUpdateDetails<Scanning.Extended.UpdateExtendedDetails>(extendedSerializer, extendedDirectory,
                        updateId, Scanning.Extended.UpdateExtendedDetails.RootNodeName);
                continue;
            }
            return;
        }

        private static T ReadWSUSScanUpdateDetails<T>(XmlSerializer serializer, DirectoryInfo from, uint id,
            string rootNodeName, params Tuple<string, string>[] namespaces)
        {
            FileInfo targetFile = new FileInfo(Path.Combine(from.FullName, id.ToString()));
            if (!targetFile.Exists) {
                throw new ApplicationException("BUG");
            }
            using (XmlFragmentSerializationWrapper wrapper = new XmlFragmentSerializationWrapper(targetFile, rootNodeName, namespaces)) {
                try {
                    _xmlParsingErrorEncountered = false;
                    Console.WriteLine(id.ToString());
                    T result = (T) serializer.Deserialize(wrapper);
                    if (_xmlParsingErrorEncountered) {
                        wrapper.DumpContent();
                        int i = 1;
                    }
                    return result;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    wrapper.DumpContent();
                    throw;
                }
            }
        }

        private static void TraceUnknownAttribute(XmlAttributeEventArgs e)
        {
            _xmlParsingErrorEncountered = true;
            Console.Write("Unknown attribute '{0}/{1}' at L{2}/C{3}",
                e.Attr.NamespaceURI ?? "NONE", e.Attr.LocalName ?? "NONE", e.LineNumber, e.LinePosition);
            if (null != e.Attr.ParentNode) {
                Console.Write(" in '{0}/{1}'",
                    e.Attr.ParentNode.NamespaceURI ?? "NONE", e.Attr.ParentNode.LocalName ?? "NONE");
            }
            Console.WriteLine();
            return;
        }

        private static void TraceUnknownNode(XmlNodeEventArgs e)
        {
            _xmlParsingErrorEncountered = true;
            Console.WriteLine("Unknown {0} '{1}/{2}' at L{3}/C{4}",
                e.NodeType, e.NamespaceURI ?? "NONE", e.LocalName ?? "NONE", e.LineNumber, e.LinePosition);
            return;
        }

        private static DirectoryInfo _baseDirectory;
        private static Container _manifest;
        private static Packaging.Package _package;
        private static DirectoryInfo _packageDirectory;
        private static DirectoryInfo _psfxDirectory;
        private static bool _xmlParsingErrorEncountered;
        private static DirectoryInfo _wsusscanDirectory;

        private class UpdateItemFamily : ICloneable
        {
            internal static IEqualityComparer<UpdateItemFamily> Comparer
            {
                get { return _comparer; }
            }

            internal string PublicKeyToken { get; set; }
            internal string SyntheticName { get; set; }
            internal Version Version { get; set; }

            public object Clone()
            {
                return new UpdateItemFamily() {
                    PublicKeyToken = this.PublicKeyToken,
                    SyntheticName = this.SyntheticName,
                    Version = this.Version
                };
            }

            internal void Initialize(FileDescriptor from)
            {
                this.PublicKeyToken = from.PublicKeyToken;
                this.SyntheticName = from.SyntheticName;
                this.Version = from.Version;
            }

            private static IEqualityComparer<UpdateItemFamily> _comparer = new _Comparer();

            private class _Comparer : IEqualityComparer<UpdateItemFamily>
            {
                public bool Equals(UpdateItemFamily x, UpdateItemFamily y)
                {
                    if ((null == x) || (null == y)) { throw new ArgumentNullException(); }
                    return string.Equals(x.SyntheticName, y.SyntheticName)
                        && string.Equals(x.Version, y.Version);
                }

                public int GetHashCode(UpdateItemFamily obj)
                {
                    return (obj.SyntheticName + "/" + obj.Version).GetHashCode();
                }
            }
        }
    }
}
