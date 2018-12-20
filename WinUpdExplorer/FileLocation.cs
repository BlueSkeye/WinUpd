using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class FileLocation
    {
        /// <summary>This identifier is in fact a SHA1 has value of the file.</summary>
        [XmlAttribute()]
        public string Id { get; set; }
        [XmlAttribute("IsIncluded")]
        public bool IsIncluded { get; set; }
        [XmlAttribute("Url")]
        public string Url { get; set; }
    }
}
