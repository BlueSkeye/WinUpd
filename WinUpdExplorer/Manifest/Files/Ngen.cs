using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class Ngen
    {
        [XmlAttribute("managedversion")]
        public string ManagedVersion { get; set; }
        [XmlAttribute("parameter")]
        public string Parameter { get; set; }
        [XmlAttribute("win64targetarch")]
        public string Win64TargetArchitecture { get; set; }
    }
}
