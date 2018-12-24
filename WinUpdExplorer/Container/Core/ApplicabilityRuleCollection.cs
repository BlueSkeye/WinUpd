using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class ApplicabilityRuleCollection
    {
        [XmlElement("IsInstalled")]
        public InstalledCondition IsInstalled { get; set; }
    }
}
