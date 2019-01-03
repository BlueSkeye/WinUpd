using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class AssemblyBase
    {
        [XmlAttribute("company")]
        public string Company { get; set; }
        [XmlAttribute("copyright")]
        public string Copyright { get; set; }
        [XmlAttribute("creationTimeStamp")]
        public string CreationTimeStamp { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute("lastUpdateTimeStamp")]
        public string LastUpdateTimeStamp { get; set; }
        [XmlAttribute("manifestVersion")]
        public string ManifestVersion { get; set; }
        [XmlAttribute("supportInformation")]
        public string SupportInformation { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity { get; set; }
        [XmlElement("package")]
        public Package[] Packages { get; set; }
    }
}
