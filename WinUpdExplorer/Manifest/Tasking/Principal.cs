using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class Principal
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("GroupId")]
        public string GroupId { get; set; }
        [XmlElement("RunLevel")]
        public string RunLevel { get; set; }
        [XmlElement("UserId")]
        public string UserId { get; set; }
    }
}
