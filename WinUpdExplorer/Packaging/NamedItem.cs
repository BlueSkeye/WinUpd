using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class NamedItem
    {
        [XmlAttribute()]
        public string Name { get; set; }
    }
}
