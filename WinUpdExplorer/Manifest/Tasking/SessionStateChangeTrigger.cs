using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class SessionStateChangeTrigger : TriggerBase
    {
        [XmlElement("StateChange")]
        public string StateChange { get; set; }
    }
}
