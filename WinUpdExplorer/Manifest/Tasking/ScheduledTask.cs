using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduledTask
    {
        [XmlArray("Actions"),
            XmlArrayItem(ElementName = "Exec", Type = typeof(ScheduledTaskExecAction))]
        public ScheduledTaskActionBase[] Actions { get; set; }
        [XmlArray("Principals"),
            XmlArrayItem(ElementName = "Principal", Type = typeof(Principal))]
        public Principal[] Principals { get; set; }
        [XmlElement("RegistrationInfo")]
        public ScheduledTaskRegistrationInfo RegistrationInfo { get; set; }
        [XmlElement("Settings")]
        public ScheduledTaskSettings Settings { get; set; }
        [XmlArray("Triggers"),
            XmlArrayItem(ElementName = "BootTrigger", Type = typeof(ScheduledTaskBootTrigger))]
        public ScheduledTaskTriggerBase[] Triggers { get; set; }
    }
}
