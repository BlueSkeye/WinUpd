using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class DeconstructionTool
    {
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
