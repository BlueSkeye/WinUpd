using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Pattern
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlText()]
        public string Content { get; set; }
    }
}
