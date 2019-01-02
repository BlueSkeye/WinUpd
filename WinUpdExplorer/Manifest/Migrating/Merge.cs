using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Merge : FilteredContent
    {
        [XmlAttribute("script")]
        public string Script { get; set; }
    }
}
