using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class ServiceData
    {
        [XmlAttribute("failureActionsFlag")]
        public bool FailureActionsFlag { get; set; }
        [XmlAttribute("dependOnService")]
        public string DependOnService { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute("errorControl")]
        public string ErrorControl { get; set; }
        [XmlAttribute("group")]
        public string Group { get; set; }
        [XmlAttribute("imagePath")]
        public string Imagepath { get; set; }
        [XmlAttribute("launchProtected")]
        public string LaunchProtected { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("objectName")]
        public string ObjectName { get; set; }
        [XmlAttribute("requiredPrivileges")]
        public string RequiredPrivileges { get; set; }
        [XmlAttribute("sidType")]
        public string SidType { get; set; }
        [XmlAttribute("start")]
        public string Start { get; set; }
        [XmlAttribute("startAfterInstall")]
        public string StartAfterInstall { get; set; }
        [XmlAttribute("tag")]
        public uint Tag { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("failureActions")]
        public FailureActions FailureActions { get; set; }
        [XmlElement("securityDescriptor")]
        public SecurityDescriptor SecurityDescriptor { get; set; }
        [XmlElement("serviceTrigger", Namespace = XmlNamespaces.AssemblyV3)]
        public ServiceTrigger[] ServiceTriggers { get; set; }
    }
}
