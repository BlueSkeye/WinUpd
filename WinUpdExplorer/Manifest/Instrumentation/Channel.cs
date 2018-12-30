using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Channel : ChannelBase
    {
        [XmlAttribute("access")]
        public string Access { get; set; }
        [XmlAttribute("enabled")]
        public bool Enabled { get; set; }
        [XmlAttribute("isolation")]
        public string Isolation { get; set; }
        [XmlElement("logging")]
        public ChannelLogging Logging { get; set; }
        [XmlAttribute("message")]
        public string Message { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlText()]
        public string Value { get; set; }
    }
}
