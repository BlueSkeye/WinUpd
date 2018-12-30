using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class ServiceTrigger
    {
        [XmlAttribute("action")]
        public string Action { get; set; }
        [XmlAttribute("subtype")]
        public string SubType { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("triggerData")]
        public TriggerData TriggerData { get; set; }
    }
}
