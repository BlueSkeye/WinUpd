using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class Instance
    {
        [XmlElement("filter", Namespace = XmlNamespaces.AssemblyV3)]
        public Filter Filter { get; set; }
        [XmlElement("providerOrder")]
        public ProviderOrder ProviderOrder { get; set; }
        [XmlAttribute("subcategory")]
        public string Subcategory { get; set; }
        [XmlElement("serviceData")]
        public ServiceData ServiceData { get; set; }
        [XmlElement("serviceGroup")]
        public ServiceGroup ServiceGroup { get; set; }
        [XmlElement("shortCut")]
        public Shortcut Shortcut { get; set; }
    }
}
