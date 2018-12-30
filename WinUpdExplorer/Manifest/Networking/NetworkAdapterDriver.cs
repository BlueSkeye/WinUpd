using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class NetworkAdapterDriver
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("ifDescrSeed")]
        public string InterfaceDescription { get; set; }
        [XmlAttribute("ifType")]
        public string InterfaceType { get; set; }
        [XmlAttribute("isVirtual")]
        public bool IsVirtual { get; set; }
        [XmlAttribute("mediaType")]
        public string MediaType { get; set; }
        [XmlAttribute("physicalMediaType")]
        public string PhysicalMediaType { get; set; }

        [XmlElement("bind")]
        public NetworkBinding[] Bindings { get; set; }
        [XmlElement("property")]
        public NetworkAdapterProperty[] Properties { get; set; }
    }
}
