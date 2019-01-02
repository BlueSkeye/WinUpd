using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class TimeTrigger : TriggerBase
    {
        [XmlElement("EndBoundary")]
        public string EndBoundary { get; set; }
        [XmlElement("RandomDelay")]
        public string RandomDelay { get; set; }
        [XmlElement("Repetition")]
        public Repetition Repetition { get; set; }
        [XmlElement("StartBoundary")]
        public string StartBoundary { get; set; }
    }
}
