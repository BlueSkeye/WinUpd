using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class InstalledCondition : CompositeConditionBase
    {
        [XmlElement("True")]
        public AlwaysTrueCondition AlwaysTrue { get; set; }
        [XmlElement("And")]
        public AndInstalledCondition And { get; set; }
        [XmlElement("Not")]
        public NotInstalledCondition Not { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition Or { get; set; }
    }
}
