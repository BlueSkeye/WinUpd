using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class ChannelLogging
    {
        [XmlElement("maxSize")]
        public string MaximumSize { get; set; }
        [XmlElement("retention")]
        public string Retention { get; set; }
    }
}
