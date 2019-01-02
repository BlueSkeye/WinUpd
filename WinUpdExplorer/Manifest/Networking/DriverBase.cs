using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class DriverBase
    {
        [XmlAttribute("displayDescription")]
        public string DisplayDescription { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute("identifier")]
        public string Identifier { get; set; }

        [XmlElement("bind")]
        public NetworkBinding[] Bindings { get; set; }
        [XmlElement("property")]
        public NetworkAdapterProperty[] Properties { get; set; }
    }
}
