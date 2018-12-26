using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class FileExistsCondition
    {
        [XmlAttribute("Csidl")]
        public uint Csidl { get; set; }
        [XmlAttribute("Language")]
        public string Language { get; set; }
        [XmlAttribute("Path")]
        public string Path { get; set; }
        [XmlAttribute("Size")]
        public uint Size { get; set; }
    }
}
