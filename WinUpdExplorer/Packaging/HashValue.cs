using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class HashValue
    {
        [XmlAttribute("alg")]
        public string Algorithm { get; set; }
        [XmlElement("Delta")]
        public Delta Delta { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
