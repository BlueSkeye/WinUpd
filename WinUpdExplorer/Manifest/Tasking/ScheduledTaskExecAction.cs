using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduledTaskExecAction : ScheduledTaskActionBase
    {
        [XmlElement("Arguments")]
        public string Arguments { get; set; }
        [XmlElement("Command")]
        public string Command { get; set; }
    }
}
