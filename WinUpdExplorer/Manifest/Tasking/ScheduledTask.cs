using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduledTask
    {
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlElement("Actions")]
        public ActionSet Actions { get; set; }
        [XmlArray("Principals"),
            XmlArrayItem(ElementName = "Principal", Type = typeof(Principal))]
        public Principal[] Principals { get; set; }
        [XmlElement("RegistrationInfo")]
        public RegistrationInfo RegistrationInfo { get; set; }
        [XmlElement("Settings")]
        public Settings Settings { get; set; }
        [XmlArray("Triggers"),
            XmlArrayItem(ElementName = "BootTrigger", Type = typeof(BootTrigger)),
            XmlArrayItem(ElementName = "CalendarTrigger", Type = typeof(CalendarTrigger)),
            XmlArrayItem(ElementName = "EventTrigger", Type = typeof(EventTrigger)),
            XmlArrayItem(ElementName = "IdleTrigger", Type = typeof(IdleTrigger)),
            XmlArrayItem(ElementName = "LogonTrigger", Type = typeof(LogonTrigger)),
            XmlArrayItem(ElementName = "SessionStateChangeTrigger", Type = typeof(SessionStateChangeTrigger)),
            XmlArrayItem(ElementName = "TimeTrigger", Type = typeof(TimeTrigger)),
            XmlArrayItem(ElementName = "WnfStateChangeTrigger", Type = typeof(WnfStateChangeTrigger))]
        public TriggerBase[] Triggers { get; set; }
    }
}
