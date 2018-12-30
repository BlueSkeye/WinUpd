using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class MofDefinition
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("uninstallmof")]
        public string Uninstall { get; set; }
    }
}
