using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Variable
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlElement("script")]
        public string Script { get; set; }
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
