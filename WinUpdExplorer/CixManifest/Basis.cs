using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.CixManifest
{
    public class Basis
    {
        [XmlAttribute("file")]
        public uint File { get; set; }
    }
}
