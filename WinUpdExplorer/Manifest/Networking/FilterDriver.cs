using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class FilterDriver
    {
        [XmlAttribute("bindGuid")]
        public string BindGuid { get; set; }
        [XmlAttribute("displayDescription")]
        public string DisplayDescription { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName{ get; set; }
        [XmlAttribute("filterClass")]
        public string FilterClass { get; set; }
        [XmlAttribute("hidden")]
        public bool Hidden { get; set; }
        [XmlAttribute("identifier")]
        public string Identifier { get; set; }
        [XmlAttribute("mandatory")]
        public bool Mandatory { get; set; }
        [XmlAttribute("nonUserRemovable")]
        public bool NonUserRemovable { get; set; }
        [XmlAttribute("noStartAtBoot")]
        public bool NoStartAtBoot { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("unbindOnAttach")]
        public bool UnbindOnAttach { get; set; }
        [XmlAttribute("unbindOnDetach")]
        public bool UnbindOnDetach { get; set; }

        [XmlElement("bind")]
        public NetworkBinding[] Bindings { get; set; }
        [XmlElement("property")]
        public NetworkAdapterProperty[] Properties { get; set; }
    }
}
