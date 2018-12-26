using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class RegKeyLoopCondition : LogicalCompositeConditionBase
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("RegType32")]
        public bool RegType32 { get; set; }
        [XmlAttribute("Subkey")]
        public string SubKey { get; set; }
        [XmlAttribute("TrueIf")]
        public string TrueIf { get; set; }
    }
}
