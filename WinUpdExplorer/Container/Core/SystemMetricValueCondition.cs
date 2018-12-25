using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class SystemMetricValueCondition
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Index")]
        public uint Index { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
