using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Configuration
{
    public class Metadata
    {
        [XmlElement("elements")]
        public Elements Elements { get; set; }
    }
}
