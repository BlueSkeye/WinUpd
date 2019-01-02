using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class WnfStateChangeTrigger : TriggerBase
    {
        [XmlElement("Data")]
        public string Data { get; set; }
        [XmlElement("StateName")]
        public string StateName { get; set; }
    }
}
