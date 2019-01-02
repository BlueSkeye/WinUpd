using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class ProtocolDriverProperty
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
