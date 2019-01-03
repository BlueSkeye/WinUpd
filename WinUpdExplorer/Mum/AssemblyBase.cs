using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class AssemblyBase : AssemblyCommonBase
    {
        [XmlAttribute("company")]
        public string Company { get; set; }
        [XmlAttribute("creationTimeStamp")]
        public string CreationTimeStamp { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute("lastUpdateTimeStamp")]
        public string LastUpdateTimeStamp { get; set; }
        [XmlAttribute("supportInformation")]
        public string SupportInformation { get; set; }

        [XmlElement("package")]
        public Package[] Packages { get; set; }
    }
}
