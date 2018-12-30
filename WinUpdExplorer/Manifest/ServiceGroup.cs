using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class ServiceGroup
    {
        [XmlAttribute("position")]
        public string Position { get; set; }
        [XmlAttribute("serviceName")]
        public string ServiceName { get; set; }
    }
}
