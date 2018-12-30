using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FailureAction
    {
        [XmlAttribute("delay")]
        public uint Delay { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
