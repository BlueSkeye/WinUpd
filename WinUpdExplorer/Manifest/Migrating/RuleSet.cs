using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class RuleSet : Detectable
    {
        [XmlElement("conditions")]
        public ConditionSet Conditions { get; set; }
        [XmlElement("contentModify")]
        public ContentModify[] ContentModifies { get; set; }
        [XmlAttribute("context")]
        public string Context { get; set; }
        [XmlElement("destinationCleanup")]
        public DestinationCleanup[] DestinationCleanups { get; set; }
        [XmlElement("destinationcleanup")]
        public DestinationCleanup[] _1 { get { return DestinationCleanups; } set { DestinationCleanups = value; } }
        [XmlElement("exclude")]
        public Exclusion[] Excludes { get; set; }
        [XmlElement("include")]
        public Inclusion[] Includes { get; set; }
        [XmlElement("locationModify")]
        public LocationModify[] LocationModifies { get; set; }
        [XmlElement("merge")]
        public Merge[] Merges { get; set; }
        [XmlElement("processing")]
        public Processing[] Processings { get; set; }
    }
}
