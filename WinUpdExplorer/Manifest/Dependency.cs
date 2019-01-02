using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Dependency
    {
        [XmlAttribute("discoverable")]
        public string Discoverable { get; set; }
        [XmlAttribute("offlineInstall")]
        public bool OfflineInstall { get; set; }
        [XmlAttribute("resourceType")]
        public string ResourceType { get; set; }

        [XmlElement("dependentAssembly")]
        public DependentAssembly DependentAssembly { get; set; }
    }
}
