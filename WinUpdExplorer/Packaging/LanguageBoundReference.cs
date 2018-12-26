using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class LanguageBoundReference : IdReference
    {
        [XmlElement("Language")]
        public NamedItem Name { get; set; }
    }
}
