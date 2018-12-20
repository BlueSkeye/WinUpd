using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Dependency
    {
        [XmlAttribute("discoverable")]
        public string Discoverable { get; set; }

        [XmlElement("dependentAssembly")]
        public DependentAssembly DependentAssembly { get; set; }
    }
}
