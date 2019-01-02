using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Events
    {
        [XmlElement("cmi")]
        public Cmi Cmi { get; set; }
        [XmlArray("messageTable"),
            XmlArrayItem(ElementName = "message", Type = typeof(Message))]
        public Message[] Messages { get; set; }
        [XmlElement("provider")]
        public EventProvider[] Provider { get; set; }
    }
}
