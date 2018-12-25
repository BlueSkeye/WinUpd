using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class FileVersionCondition
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Csidl")]
        public string Csidl { get; set; }
        [XmlAttribute("Path")]
        public string Path { get; set; }
        [XmlAttribute("Version")]
        public string Version { get; set; }
    }
}
