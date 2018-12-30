using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class LocationModify
    {
        [XmlAttribute("script")]
        public string Script { get; set; }
        [XmlArray("objectSet"),
            XmlArrayItem(ElementName = "pattern", Type = typeof(Pattern))]
        public Pattern[] Patterns { get; set; }
    }
}
