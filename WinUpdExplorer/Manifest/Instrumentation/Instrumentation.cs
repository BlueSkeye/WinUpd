using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Instrumentation
    {
        [XmlElement("events", Namespace = XmlNamespaces.Events)]
        public Events Events { get; set; }
        public CounterCollection Counters { get; set; }
        [XmlElement("counters", Namespace = XmlNamespaces.Counters)]
        public CounterCollection _1 { get { return Counters; } set { Counters = value; } }
        [XmlElement("counters", Namespace = XmlNamespaces.AssemblyV3)]
        public CounterCollection _2 { get { return Counters; } set { Counters = value; } }
    }
}
