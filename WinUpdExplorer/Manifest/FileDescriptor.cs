using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FileDescriptor
    {
        [XmlAttribute("compress")]
        public bool Compress { get; set; }
        [XmlAttribute("destinationPath")]
        public string DestinationPath { get; set; }
        [XmlAttribute("importPath")]
        public string ImportPath { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("sourceName")]
        public string SourceName { get; set; }
        [XmlAttribute("sourcePath")]
        public string SourcePath { get; set; }
        [XmlAttribute("writeableType")]
        public string WriteableType { get; set; }

        [XmlElement("dependencies")]
        public DependencyCollection Dependencies { get; set; }
        [XmlElement("hash", Namespace = XmlNamespaces.AssemblyV2)]
        public HashDescriptor HashValue { get; set; }
        [XmlElement("infFile")]
        public InformationFile InfFile { get; set; }
        [XmlElement("lodctr", Namespace = XmlNamespaces.AssemblyV3)]
        public LodCtr LodCtr { get; set; }
        [XmlElement("securityDescriptor")]
        public SecurityDescriptor SecurityDescriptor { get; set; }
        [XmlElement("signatureInfo", Namespace = XmlNamespaces.AssemblyV3)]
        public SignatureInformation SignatureInformation { get; set; }
    }
}
