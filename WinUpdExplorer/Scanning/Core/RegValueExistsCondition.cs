using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class RegValueExistsCondition : RegConditionBase
    {
        [XmlAttribute("Type")]
        public string Type { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
