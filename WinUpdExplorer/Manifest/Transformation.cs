using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Transformation
    {
        [XmlAttribute("Algorithm")]
        public string Algorithm { get; set; }
    }
}
