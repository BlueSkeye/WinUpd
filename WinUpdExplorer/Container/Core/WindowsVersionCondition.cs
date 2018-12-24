using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class WindowsVersionCondition
    {
        [XmlAttribute("BuildNumber")]
        public uint BuildNumber { get; set; }
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("MajorVersion")]
        public uint MajorVersion { get; set; }
        [XmlAttribute("MinorVersion")]
        public uint MinorVersion { get; set; }
        [XmlAttribute("ProductType")]
        public uint ProductType { get; set; }
    }
}
