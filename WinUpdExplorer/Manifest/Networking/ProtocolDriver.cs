using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class ProtocolDriver
    {
        [XmlAttribute("bindName")]
        public string BindingName { get; set; }
        [XmlAttribute("defaultDisable")]
        public bool DefaultDisable { get; set; }
        [XmlAttribute("displayDescription")]
        public string DisplayDescription { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName{ get; set; }
        [XmlAttribute("hidden")]
        public bool Hidden { get; set; }
        [XmlAttribute("identifier")]
        public string Identifier { get; set; }
        [XmlAttribute("noStartAtBoot")]
        public bool NoStartAtBoot { get; set; }
        [XmlAttribute("nonUserRemovable")]
        public bool NonUserRemovable { get; set; }

        [XmlElement("bind")]
        public NetworkBinding[] Bindings { get; set; }
    }
}
