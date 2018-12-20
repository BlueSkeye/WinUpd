using System;
using System.IO;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public static partial class Program
    {
        public static int Main(string[] args)
        {
            Initialize();
            // bool allConjectureStand = WsusScanParallelContentConjecture(); // UNUSED
            // Read the package.xml file from WSUSSCAN directory.
            ReadPackage();
            // Build inter Update dependencies from package content.
            UpdateDependencyManager dependencyManager = new UpdateDependencyManager(_package);
            dependencyManager.BuildDependencies();
            // Build updates details from the content of the core, extended and localized
            // sub-directories of WSUSSCAN.
            ReadUpdatesDetails();
            // ReadManifest(); // UNUSED
            VerifyManifestSyntax();
            return 0;
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

        private static void ReadPackage()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Container.Package));
            serializer.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                return;
            });
            serializer.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                return;
            });
            using (FileStream input = File.OpenRead(Path.Combine(_wsusscanDirectory.FullName, "package.xml"))) {
                _package = (Container.Package)serializer.Deserialize(input);
            }
            return;
        }

        private static void ReadUpdateCoreDetails(XmlSerializer serializer, DirectoryInfo from,
            uint id)
        {
            FileInfo targetFile = new FileInfo(Path.Combine(from.FullName, id.ToString()));
            if (!targetFile.Exists) {
                throw new ApplicationException("BUG");
            }
            using (XmlFragmentSerializationWrapper wrapper =
                new XmlFragmentSerializationWrapper(targetFile, Container.UpdateCoreDetails.RootNodeName)) {
                serializer.Deserialize(wrapper);
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
            XmlSerializer coreSerializer = new XmlSerializer(typeof(Container.UpdateCoreDetails));
            coreSerializer.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                return;
            });
            coreSerializer.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                return;
            });
            foreach (uint updateId in _package.EnumerateUpdateIds()) {
                ReadUpdateCoreDetails(coreSerializer, coreDirectory, updateId);
            }
            return;
        }

        private static void VerifyManifestSyntax()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Manifest.Assembly));
            serializer.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                return;
            });
            serializer.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                return;
            });
            int successCount = 0;
            int failureCount = 0;
            foreach(FileInfo candidate in _psfxDirectory.GetFiles("*.manifest")) {
                using (FileStream input = File.OpenRead(candidate.FullName)) {
                    try {
                        Manifest.Assembly assemblyManifest = (Manifest.Assembly)serializer.Deserialize(input);
                        string discoverable = assemblyManifest.Dependency.Discoverable;
                        if (("no" != discoverable) && ("false" != discoverable)) {
                            throw new NotImplementedException();
                        }
                        successCount++;
                    }
                    catch (Exception e) {
                        // TODO : These are file using the "urn:schemas-microsoft-com:asm.v1" namespace.
                        if (null != e.InnerException) {
                            Console.WriteLine(e.InnerException.Message);
                        }
                        failureCount++;
                    }
                }
            }
            return;
        }

        private static DirectoryInfo _baseDirectory;
        private static Container.Package _package;
        private static DirectoryInfo _packageDirectory;
        private static DirectoryInfo _psfxDirectory;
        private static DirectoryInfo _wsusscanDirectory;
    }
}
