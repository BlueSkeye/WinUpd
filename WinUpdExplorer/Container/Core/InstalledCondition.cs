using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class InstalledCondition
    {
        [XmlElement("And")]
        public AndInstalledCondition And { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition Or { get; set; }
        [XmlElement("b.RegDword")]
        public RegDwordCondition[] RegDword { get; set; }
        [XmlElement("b.WindowsVersion")]
        public WindowsVersionCondition[] WindowsVersion { get; set; }
    }
}
