using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Processing
    {
        [XmlElement("script")]
        public string Script { get; set; }
        [XmlAttribute("when")]
        public string When { get; set; }
    }
}
