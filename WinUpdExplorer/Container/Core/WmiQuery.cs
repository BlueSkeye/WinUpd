using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class WmiQuery
    {
        [XmlAttribute("Namespace")]
        public string Namespace { get; set; }
        [XmlAttribute("WqlQuery")]
        public string Query { get; set; }
    }
}
