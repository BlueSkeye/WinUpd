using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class LicenceDwordCondition
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Data")]
        public string Data { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
