using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduleByDay
    {
        [XmlElement("DaysInterval")]
        public uint DaysInterval { get; set; }
    }
}
