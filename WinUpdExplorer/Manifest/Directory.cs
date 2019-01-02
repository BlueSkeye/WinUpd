using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Directory
    {
        [XmlAttribute("attributes")]
        public string Attributes { get; set; }
        [XmlAttribute("compression")]
        public string Compression { get; set; }
        [XmlAttribute("destinationPath")]
        public string DestinationPath { get; set; }
        [XmlAttribute("owner")]
        public string Owner { get; set; }
        [XmlElement("securityDescriptor")]
        public SecurityDescriptor SecurityDescriptor { get; set; }
    }
}
