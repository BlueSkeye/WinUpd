using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class Source
    {
        [XmlElement("Hash")]
        public HashValue Hash { get; set; }
        /// <summary>For RAW type source file the name value matches the one of the outer File element.
        /// For PA30 type source file this is an index value from 0 for first delta, 1 second delta to
        /// process and so on.</summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
        /// <summary>Source type: RAW or PA30. RAW means that no delta-compression is implemented.
        /// PA30 means that the file in the cab file is a delta.</summary>
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
