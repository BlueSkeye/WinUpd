using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class CustomInformation
    {
        [XmlAttribute("Dependency")]
        public string Dependency { get; set; }
        [XmlAttribute("PackageFormat")]
        public string PackageFormat { get; set; }
        [XmlAttribute("Version")]
        public string Version { get; set; }
    }
}
