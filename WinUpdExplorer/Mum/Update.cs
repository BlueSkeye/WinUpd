using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Update
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("applicable")]
        public Applicable Applicable { get; set; }
        [XmlElement("component")]
        public Component Component { get; set; }
        [XmlElement("driver")]
        public Driver Driver { get; set; }
        [XmlElement("package")]
        public Package Package { get; set; }
    }
}
