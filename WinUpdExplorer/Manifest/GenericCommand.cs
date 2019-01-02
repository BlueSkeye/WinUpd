using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class GenericCommand
    {
        [XmlAttribute("arguments")]
        public string Arguments { get; set; }
        [XmlAttribute("executableName")]
        public string ExcutableName { get; set; }
        [XmlAttribute("install")]
        public bool Install { get; set; }
        [XmlAttribute("successCode")]
        public string SuccessCode { get; set; }
    }
}
