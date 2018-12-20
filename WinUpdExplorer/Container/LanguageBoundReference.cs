using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class LanguageBoundReference : IdReference
    {
        [XmlElement("Language")]
        public NamedItem Name { get; set; }
    }
}
