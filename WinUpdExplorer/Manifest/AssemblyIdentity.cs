using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class AssemblyIdentity
    {
        [XmlAttribute("language")]
        public string Language { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("processorArchitecture")]
        public string ProcessorArchitecture { get; set; }

        [XmlAttribute("publicKeyToken")]
        public string PublicKeyToken { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
