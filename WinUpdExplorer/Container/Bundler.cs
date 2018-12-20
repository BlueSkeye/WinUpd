using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class Bundler
    {
        [XmlElement(ElementName = "Revision")]
        public RevisionReference Revision { get; set;}

        public class RevisionReference
        {
            [XmlAttribute("Id")]
            public uint Id { get; set; }
        }
    }
}
