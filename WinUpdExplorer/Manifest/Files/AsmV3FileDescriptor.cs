using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class AsmV3FileDescriptor : FileDescriptorBase
    {
        [XmlAttribute("attributes")]
        public string Attributes { get; set; }
        [XmlAttribute("compress")]
        public bool Compress { get; set; }
        [XmlAttribute("destinationPath")]
        public string DestinationPath { get; set; }
        [XmlAttribute("sourcePath")]
        public string SourcePath { get; set; }
        [XmlAttribute("writeableType")]
        public string WriteableType { get; set; }

        [XmlElement("dependencies")]
        public DependencyCollection Dependencies { get; set; }
        [XmlElement("gac", Namespace = XmlNamespaces.AssemblyV3)]
        public Gac Gac { get; set; }
        [XmlElement("infFile")]
        public InformationFile InfFile { get; set; }
        [XmlElement("lodctr", Namespace = XmlNamespaces.AssemblyV3)]
        public LodCtr LodCtr { get; set; }
        [XmlElement("ngen", Namespace = XmlNamespaces.AssemblyV3)]
        public Ngen Ngen { get; set; }
        [XmlElement("securityDescriptor")]
        public SecurityDescriptor SecurityDescriptor { get; set; }
    }
}
