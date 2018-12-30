using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class Instance
    {
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
