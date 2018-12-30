using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class ConditionSet
    {
        [XmlAttribute("operation")]
        public string LogicalConnector { get; set; }
        [XmlElement("condition")]
        public string[] Conditions { get; set; }
    }
}
