using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class ObjectSet
    {
        [XmlElement("content")]
        public FilteredContent[] Contents { get; set; }
        [XmlElement("pattern")]
        public Pattern[] Patterns { get; set; }
    }
}
