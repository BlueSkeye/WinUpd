using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class LogicalCompositeConditionBase : CompositeConditionBase
    {
        [XmlElement("And")]
        public AndInstalledCondition[] And { get; set; }
        [XmlElement("Not")]
        public NotInstalledCondition[] Not { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition[] Or { get; set; }
    }
}
