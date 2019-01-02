using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Configuration
{
    public class AssemblyConfiguration
    {
        [XmlAttribute("buildfilter")]
        public string BuildFilter { get; set; }
        [XmlElement("configurationSchema")]
        public Schema Schema { get; set; }
        [XmlElement("metadata")]
        public Metadata Metadata { get; set; }
    }
}
