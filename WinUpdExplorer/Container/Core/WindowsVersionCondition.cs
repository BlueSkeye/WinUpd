using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class WindowsVersionCondition
    {
        [XmlAttribute("AllSuitesMustBePresent")]
        public bool AllSuitesMustBePresent { get; set; }
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
        [XmlAttribute("ServicePackMajor")]
        public uint ServicePackMajor { get; set; }
        [XmlAttribute("SuiteMask")]
        public uint SuiteMask { get; set; }
    }
}
