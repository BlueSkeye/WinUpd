using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class RuleSet
    {
        [XmlAttribute("context")]
        public string Context { get; set; }
        [XmlElement("exclude")]
        public Exclusion Excludes { get; set; }
        [XmlElement("include")]
        public Inclusion Includes { get; set; }
        [XmlElement("locationModify")]
        public LocationModify LocationModify { get; set; }
        [XmlElement("merge")]
        public Merge Merge { get; set; }
    }
}
