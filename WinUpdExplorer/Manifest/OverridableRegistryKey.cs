using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class OverridableRegistryKey
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("scope")]
        public string Scope { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
