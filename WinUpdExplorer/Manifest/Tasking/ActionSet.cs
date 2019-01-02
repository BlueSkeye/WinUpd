using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ActionSet
    {
        [XmlAttribute("Context")]
        public string Context { get; set; }
        [XmlElement("ComHandler")]
        public ComHandler[] ComHandlers { get; set; }
        [XmlElement("Exec")]
        public ExecAction[] ExecActions { get; set; }
    }
}
