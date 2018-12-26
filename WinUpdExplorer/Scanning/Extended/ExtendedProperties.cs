using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Extended
{
    public class ExtendedProperties
    {
        [XmlAttribute("DefaultPropertiesLanguage")]
        public string DefaultPropertiesLanguage { get; set; }
        [XmlAttribute("Handler")]
        public string Handler { get; set; }
    }
}
