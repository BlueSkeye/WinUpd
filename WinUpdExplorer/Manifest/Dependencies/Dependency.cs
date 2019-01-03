using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Dependencies
{
    public class Dependency
    {
        [XmlAttribute("discoverable", Namespace = XmlNamespaces.AssemblyV3)]
        public string Discoverable { get; set; }
        [XmlAttribute("offlineInstall")]
        public bool OfflineInstall { get; set; }
        [XmlAttribute("optional")]
        public string Optional { get; set; }
        [XmlAttribute("resourceType", Namespace = XmlNamespaces.AssemblyV3)]
        public string ResourceType { get; set; }

        [XmlElement("dependentAssembly")]
        public DependentAssembly DependentAssembly { get; set; }
    }
}
