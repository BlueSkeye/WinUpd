using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class NotInstalledCondition : CompositeConditionBase
    {
        [XmlElement("And")]
        public AndInstalledCondition[] And { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition[] Or { get; set; }
    }
}
