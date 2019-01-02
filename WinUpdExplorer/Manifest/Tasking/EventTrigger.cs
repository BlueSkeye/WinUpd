using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class EventTrigger: TriggerBase
    {
        [XmlElement("Subscription")]
        public string Subscription { get; set; }
    }
}
