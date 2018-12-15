using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class NamedItem
    {
        [XmlAttribute()]
        public string Name { get; set; }
    }
}
