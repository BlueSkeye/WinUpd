using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class FailureActions
    {
        [XmlAttribute("command")]
        public string Command { get; set; }
        [XmlAttribute("rebootMessage")]
        public string RebootMessage { get; set; }
        [XmlAttribute("resetPeriod")]
        public uint ResetPeriod { get; set; }
        [XmlArray("actions"),
            XmlArrayItem(ElementName = "action", Type = typeof(FailureAction))]
        public FailureAction[] Actions { get; set; }
    }
}
