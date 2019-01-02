using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Configuration
{
    public class AutoProxyListItem
    {
        [XmlElement("DllFile")]
        public string DllFile { get; set; }
        [XmlElement("Default")]
        public string Default { get; set; }
        [XmlElement("FileExtensions")]
        public string FileExtensions { get; set; }
        [XmlElement("Flags")]
        public string Flags { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
