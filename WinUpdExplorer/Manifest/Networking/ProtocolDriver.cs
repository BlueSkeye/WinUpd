using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class ProtocolDriver : DriverBase
    {
        [XmlAttribute("bindName")]
        public string BindingName { get; set; }
        [XmlAttribute("defaultDisable")]
        public bool DefaultDisable { get; set; }
        [XmlAttribute("hidden")]
        public bool Hidden { get; set; }
        [XmlAttribute("noStartAtBoot")]
        public bool NoStartAtBoot { get; set; }
        [XmlAttribute("nonUserRemovable")]
        public bool NonUserRemovable { get; set; }
    }
}
