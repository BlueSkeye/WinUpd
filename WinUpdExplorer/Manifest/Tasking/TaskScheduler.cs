using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class TaskScheduler
    {
        [XmlElement("Task", Namespace = XmlNamespaces.Task)]
        public ScheduledTask[] Tasks { get; set; }
    }
}
