﻿using System;
using System.IO;
using System.Text;
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

        private static XmlSerializer CreateWSUSScanUpdateSerializer<T>()
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
            XmlSerializer serializer = new XmlSerializer(typeof(Packaging.Package));
            serializer.UnknownNode += new XmlNodeEventHandler(delegate (object sender, XmlNodeEventArgs e) {
                TraceUnknownNode(e);
                return;
            });
            serializer.UnknownAttribute += new XmlAttributeEventHandler(delegate (object sender, XmlAttributeEventArgs e) {
                TraceUnknownAttribute(e);
                return;
            });
            using (FileStream input = File.OpenRead(Path.Combine(_wsusscanDirectory.FullName, "package.xml"))) {
                _package = (Packaging.Package)serializer.Deserialize(input);
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

        private static void ReadUpdatesDetails()
        {
            DirectoryInfo coreDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "core"));
            DirectoryInfo extendedDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "extended"));
            DirectoryInfo localizedDirectory = new DirectoryInfo(
                Path.Combine(_wsusscanDirectory.FullName, "localized"));

            XmlSerializer coreSerializer = CreateWSUSScanUpdateSerializer<Scanning.Core.UpdateCoreDetails>();
            XmlSerializer extendedSerializer = CreateWSUSScanUpdateSerializer<Scanning.Extended.UpdateExtendedDetails>();
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
        private static Packaging.Package _package;
        private static DirectoryInfo _packageDirectory;
        private static DirectoryInfo _psfxDirectory;
        private static bool _xmlParsingErrorEncountered;
        private static DirectoryInfo _wsusscanDirectory;
    }
}
