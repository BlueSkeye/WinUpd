using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FileDescriptor
    {
        [XmlAttribute("attr")]
        public uint Attributes { get; set; }
        [XmlElement("Delta")]
        public Delta Delta { get; set; }
        [XmlElement("Hash")]
        public HashValue Hash { get; set; }
        [XmlAttribute("id")]
        public uint Id { get; set; }
        [XmlAttribute("length")]
        public uint Length { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("time")]
        public ulong Time { get; set; }
    }
}
