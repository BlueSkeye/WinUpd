using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Extended
{
    public class HandlerSpecificData
    {
        [XmlElement("CategoryInformation")]
        public CategoryInformation CategoryInformation { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
