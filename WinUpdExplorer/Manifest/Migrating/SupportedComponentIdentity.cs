using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class SupportedComponentIdentity
    {
        [XmlAttribute("buildType")]
        public string BuildType { get; set; }
        [XmlAttribute("language")]
        public string Language { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("publicKeyToken")]
        public string PublicKeyToken { get; set; }
        [XmlAttribute("processorArchitecture")]
        public string ProcessorArchitecture { get; set; }
        [XmlAttribute("settingsVersionRange")]
        public string SettingsVersionRange { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlAttribute("versionScope")]
        public string VersionScope { get; set; }
    }
}
