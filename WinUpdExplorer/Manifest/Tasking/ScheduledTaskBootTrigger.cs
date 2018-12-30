using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduledTaskBootTrigger : ScheduledTaskTriggerBase
    {
        [XmlElement("Enabled")]
        public string Enabled { get; set; }
    }
}
