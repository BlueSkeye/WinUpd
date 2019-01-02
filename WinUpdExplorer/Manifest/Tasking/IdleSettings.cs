using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class IdleSettings
    {
        [XmlElement("Duration")]
        public string Duration { get; set; }
        [XmlElement("StopOnIdleEnd")]
        public bool StopOnIdleEnd { get; set; }
        [XmlElement("RestartOnIdle")]
        public bool RestartOnIdle { get; set; }
        [XmlElement("WaitTimeout")]
        public string WaitTimeout { get; set; }
    }
}
