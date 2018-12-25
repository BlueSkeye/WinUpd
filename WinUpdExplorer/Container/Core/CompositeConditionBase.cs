using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class CompositeConditionBase
    {
        [XmlElement("b.FileVersion")]
        public FileVersionCondition[] FileVersion { get; set; }
        [XmlElement("b.FileVersionPrependRegSz")]
        public FileVersionPrependRegSzCondition[] FileVersionPrependRegSz { get; set; }
        [XmlElement("m.MsiProductInstalled")]
        public MsiProductInstalledCondition[] MsiProductInstalled { get; set; }
        [XmlElement("b.RegDword")]
        public RegDwordCondition[] RegDword { get; set; }
        [XmlElement("b.RegKeyExists")]
        public RegKeyExistsCondition[] RegKeyExists { get; set; }
        [XmlElement("b.RegSz")]
        public RegSzCondition[] RegSz { get; set; }
        [XmlElement("b.RegSzToVersion")]
        public RegSzToVersionCondition[] RegSzToVersion { get; set; }
        [XmlElement("b.RegValueExists")]
        public RegValueExistsCondition[] RegValueExists { get; set; }
        [XmlElement("b.WindowsVersion")]
        public WindowsVersionCondition[] WindowsVersion { get; set; }
    }
}
