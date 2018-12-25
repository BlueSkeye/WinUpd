using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class OrInstalledCondition : CompositeConditionBase
    {
        [XmlElement("And")]
        public AndInstalledCondition[] And { get; set; }
        [XmlElement("Not")]
        public NotInstalledCondition[] Not { get; set; }
    }
}
