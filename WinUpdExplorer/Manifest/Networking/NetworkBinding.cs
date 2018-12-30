using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class NetworkBinding
    {
        [XmlAttribute("keyword")]
        public string Keyword { get; set; }
        [XmlAttribute("ruleType")]
        public string RuleType { get; set; }
    }
}
