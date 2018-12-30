using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Instrumentation
    {
        [XmlElement("events", Namespace = XmlNamespaces.Events)]
        public Events Events { get; set; }
        [XmlElement("counters", Namespace = XmlNamespaces.Counters)]
        public CounterCollection Counters { get; set; }
    }
}
