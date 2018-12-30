using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class InclusionExclusionBase
    {
        [XmlArray("objectSet"),
            XmlArrayItem(ElementName = "pattern", Type = typeof(Pattern))]
        public Pattern[] Patterns { get; set; }
    }
}
