using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class IdReference
    {
        [XmlAttribute()]
        public string Id { get; set; }
    }

    public class UpdateIdReference
    {
        [XmlAttribute()]
        public string Id { get; set; }
    }
}
