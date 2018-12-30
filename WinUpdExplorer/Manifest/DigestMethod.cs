using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class DigestMethod
    {
        [XmlAttribute("Algorithm")]
        public string Algorithm { get; set; }
    }
}
