using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
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
