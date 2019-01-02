using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class Filter
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("position")]
        public string Position { get; set; }
    }
}
