using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class ApplicabilityRuleCollection
    {
        [XmlElement("IsInstalled")]
        public InstalledCondition IsInstalled { get; set; }
    }
}
