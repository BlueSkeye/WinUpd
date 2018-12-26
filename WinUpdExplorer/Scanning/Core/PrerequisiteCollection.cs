using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class PrerequisiteCollection
    {
        [XmlElement("AtLeastOne")]
        public AtLeastOneCondition[] AtLeastOne { get; set; }
        [XmlElement("UpdateIdentity")]
        public UpdateIdentity[] UpdateIdentity { get; set; }
    }
}
