using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class FileLocation
    {
        [XmlAttribute()]
        public string Id { get; set; }
        [XmlAttribute()]
        public string IsIncluded { get; set; }
        [XmlAttribute()]
        public string Url { get; set; }
    }
}
