using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class IdleTrigger : TriggerBase
    {
        [XmlElement("EndBoundary")]
        public string EndBoundary { get; set; }
        [XmlElement("StartBoundary")]
        public string StartBoundary { get; set; }
    }
}
