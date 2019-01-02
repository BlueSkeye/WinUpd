using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class UnattendAction
    {
        [XmlAttribute("arguments")]
        public string Arguments { get; set; }
        [XmlAttribute("executableName")]
        public string ExecutableName { get; set; }
        [XmlAttribute("passes")]
        public string Passes { get; set; }
    }
}
