using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class RegistrationInfo
    {
        [XmlElement("Author")]
        public string Author { get; set; }
        [XmlElement("Date")]
        public string Date { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("SecurityDescriptor")]
        public string SecurityDescriptor { get; set; }
        [XmlElement("Source")]
        public string Source { get; set; }
        [XmlElement("URI")]
        public string URI { get; set; }
        [XmlElement("Version")]
        public string Version { get; set; }
    }
}
