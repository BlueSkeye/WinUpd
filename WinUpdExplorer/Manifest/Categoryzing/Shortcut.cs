using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class Shortcut
    {
        [XmlAttribute("arguments")]
        public string Arguments { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("destinationName")]
        public string DestinationName { get; set; }
        [XmlAttribute("destinationPath")]
        public string DestinationPath { get; set; }
        [XmlAttribute("displayResource")]
        public string DisplayResource { get; set; }
        [XmlAttribute("iconPath")]
        public string IconPath { get; set; }
        [XmlAttribute("targetPath")]
        public string TargetPath { get; set; }
        [XmlAttribute("windowStyle")]
        public string WindowStyle { get; set; }
    }
}
