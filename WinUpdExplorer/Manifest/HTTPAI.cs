using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class HTTPAI
    {
        [XmlElement("AddUrl")]
        public UrlDefinition[] URLs { get; set; }
    }
}
