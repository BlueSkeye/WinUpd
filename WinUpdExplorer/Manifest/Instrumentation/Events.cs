using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Events
    {
        [XmlElement("cmi")]
        public Cmi Cmi { get; set; }
        [XmlElement("provider")]
        public EventProvider[] Provider { get; set; }
    }
}
