using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class FilterDriver : DriverBase
    {
        [XmlAttribute("bindGuid")]
        public string BindGuid { get; set; }
        [XmlAttribute("filterClass")]
        public string FilterClass { get; set; }
        [XmlAttribute("hidden")]
        public bool Hidden { get; set; }
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
    }
}
