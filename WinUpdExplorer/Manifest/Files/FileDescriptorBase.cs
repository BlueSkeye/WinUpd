using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class FileDescriptorBase
    {
        [XmlAttribute("hash")]
        public string HashValue { get; set; }
        [XmlAttribute("hashalg")]
        public string HashAlgorithm { get; set; }
        [XmlAttribute("importPath", Namespace = XmlNamespaces.AssemblyV3)]
        public string ImportPath { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("sourceName", Namespace = XmlNamespaces.AssemblyV3)]
        public string SourceName { get; set; }

        [XmlElement("hash", Namespace = XmlNamespaces.AssemblyV2)]
        public HashDescriptor HashDescriptor { get; set; }
        [XmlElement("signatureInfo", Namespace = XmlNamespaces.AssemblyV3)]
        public SignatureInformation SignatureInformation { get; set; }
    }
}
