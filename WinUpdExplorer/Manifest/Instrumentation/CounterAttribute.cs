using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class CounterAttribute
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
