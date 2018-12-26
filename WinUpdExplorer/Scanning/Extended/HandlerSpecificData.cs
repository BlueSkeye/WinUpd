using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Extended
{
    public class HandlerSpecificData
    {
        [XmlElement("CategoryInformation")]
        public CategoryInformation CategoryInformation { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
