using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    [XmlRoot(ElementName = "Container", Namespace = Container.Namespace)]
    public class Container
    {
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlArray("Files"),
            XmlArrayItem(ElementName = "File", Type = typeof(FileDescriptor))]
        public FileDescriptor[] Files { get; set; }
        [XmlAttribute("length")]
        public uint Length { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("version")]
        public uint Version { get; set; }

        private const string Namespace = "urn:ContainerIndex";
    }
}
