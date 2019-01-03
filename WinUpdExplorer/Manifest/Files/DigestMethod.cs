using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class DigestMethod
    {
        [XmlAttribute("Algorithm")]
        public string Algorithm { get; set; }
    }
}
