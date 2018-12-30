using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Resources
    {
        [XmlAttribute("culture")]
        public string Culture { get; set; }
        [XmlArray("stringTable"),
            XmlArrayItem(ElementName = "string", Type = typeof(StringResourceDefinition))]
        public StringResourceDefinition[] Strings { get; set; }
    }
}
