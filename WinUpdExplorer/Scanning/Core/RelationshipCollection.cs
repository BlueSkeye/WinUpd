using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class RelationshipCollection
    {
        [XmlElement("Prerequisites")]
        public PrerequisiteCollection Prerequisites { get; set; }
    }
}
