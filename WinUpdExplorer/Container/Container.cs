using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    [XmlRoot("Container", Namespace = Container.Namespace)]
    public class Container
    {
        /// <summary>Length of the update package in bytes</summary>
        [XmlAttribute("length")]
        public string Length { get; set; }
        /// <summary>The name of the CAB file.</summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
        /// <summary>The type of the file that contains the updates (Set to CAB).</summary>
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
        /// <summary>A collection of fies within the package.</summary>
        [XmlArray("Files"), XmlArrayItem(ElementName = "File", Type = typeof(FileDescriptor))]
        public FileDescriptor[] Files { get; set; }

        private const string Namespace = "urn:ContainerIndex";
    }
}
