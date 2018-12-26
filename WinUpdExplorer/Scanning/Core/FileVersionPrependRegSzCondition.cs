using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class FileVersionPrependRegSzCondition : RegConditionBase
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Language")]
        public uint Language { get; set; }
        [XmlAttribute("Path")]
        public string Path { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
        [XmlAttribute("Version")]
        public string Version { get; set; }
    }
}
