using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class NamedItem
    {
        [XmlAttribute()]
        public string Name { get; set; }
    }
}
