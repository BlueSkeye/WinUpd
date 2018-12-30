using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class BfService
    {
        [XmlAttribute("Flags")]
        public uint Flags { get; set; }
        [XmlAttribute("Source")]
        public string Source { get; set; }
    }
}
