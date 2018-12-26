using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class Basis
    {
        [XmlAttribute("file")]
        public string File { get; set; }
    }
}
