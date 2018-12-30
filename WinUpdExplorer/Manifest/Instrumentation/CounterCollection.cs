using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class CounterCollection
    {
        [XmlAttribute("schemaVersion")]
        public string SchemaVersion { get; set; }
        [XmlElement("provider")]
        public CounterProvider[] CounterProvider { get; set; }
    }
}
