using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class TriggerBase
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("Enabled")]
        public string Enabled { get; set; }
    }
}
