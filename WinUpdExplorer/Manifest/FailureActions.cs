using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FailureActions
    {
        [XmlAttribute("resetPeriod")]
        public uint ResetPeriod { get; set; }
        [XmlArray("actions"),
            XmlArrayItem(ElementName = "action", Type = typeof(FailureAction))]
        public FailureAction[] Actions { get; set; }
    }
}
