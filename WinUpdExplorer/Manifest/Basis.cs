using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Basis
    {
        [XmlAttribute("file")]
        public uint File { get; set; }
    }
}
