using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class CalendarTrigger : TriggerBase
    {
        [XmlElement("ScheduleByDay")]
        public ScheduleByDay ScheduleByDay { get; set; }
        [XmlElement("StartBoundary")]
        public string StartBoundary { get; set; }
    }
}
