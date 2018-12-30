using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class StringResourceDefinition
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
