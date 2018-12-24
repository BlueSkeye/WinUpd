using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class RegValueExistsCondition
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("RegType32")]
        public bool RegType32 { get; set; }
        [XmlAttribute("Subkey")]
        public string SubKey { get; set; }
        [XmlAttribute("Type")]
        public string Type { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
