using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class ContentModify
    {
        [XmlAttribute("script")]
        public string Script { get; set; }
        [XmlElement("objectSet")]
        public ObjectSet ObjectSet { get; set; }
    }
}
