using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class UrlDefinition
    {
        [XmlAttribute("sddl")]
        public string SDDL { get; set; }
        [XmlAttribute("url")]
        public string URL { get; set; }
    }
}
