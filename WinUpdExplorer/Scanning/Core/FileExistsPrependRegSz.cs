using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class FileExistsPrependRegSz
    {
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("Language")]
        public uint Language { get; set; }
        [XmlAttribute("Path")]
        public string Path { get; set; }
        [XmlAttribute("Subkey")]
        public string Subkey { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}
