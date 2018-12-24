using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class AndInstalledCondition
    {
        [XmlElement("Or")]
        public OrInstalledCondition Or { get; set; }
        [XmlElement("b.RegDword")]
        public RegDwordCondition[] RegDword { get; set; }
        [XmlElement("b.RegValueExists")]
        public RegValueExistsCondition[] RegValueExists { get; set; }
        [XmlElement("b.WindowsVersion")]
        public WindowsVersionCondition[] WindowsVersion { get; set; }
    }
}
