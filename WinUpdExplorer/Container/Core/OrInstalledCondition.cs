using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class OrInstalledCondition
    {
        [XmlElement("And")]
        public AndInstalledCondition And { get; set; }
        [XmlElement("b.RegDword")]
        public RegDwordCondition[] RegDword { get; set; }
        // [XmlArrayItem("b.WindowsVersion")]
        [XmlElement("b.WindowsVersion")]
        public WindowsVersionCondition[] WindowsVersion { get; set; }
    }
}
