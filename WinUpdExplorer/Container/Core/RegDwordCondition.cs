using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class RegDwordCondition
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Data")]
        public string Data { get; set; }
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("Subkey")]
        public string SubKey { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
