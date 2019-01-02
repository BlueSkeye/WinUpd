using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Gac
    {
        [XmlAttribute("clrversion")]
        public string ClrVersion { get; set; }
        [XmlAttribute("managedculture")]
        public string ManagedCulture { get; set; }
        [XmlAttribute("managedversion")]
        public string ManagedVersion { get; set; }
        [XmlAttribute("parameter")]
        public string Parameter { get; set; }
    }
}
