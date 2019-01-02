using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Message
    {
        [XmlAttribute("message")]
        public string MessageText { get; set; }
        [XmlAttribute("mid")]
        public string MessageId { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
