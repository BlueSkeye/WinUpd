using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class FilteredContent
    {
        [XmlAttribute("filter")]
        public string Filter { get; set; }
        [XmlElement("objectSet")]
        public ObjectSet[] TargetObjects { get; set; }
    }
}
