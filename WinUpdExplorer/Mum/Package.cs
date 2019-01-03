using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Package
    {
        [XmlAttribute("applicabilityEvaluation")]
        public string ApplicabilityEvaluation { get; set; }
        [XmlAttribute("identifier")]
        public string Identifier { get; set; }
        [XmlAttribute("integrate")]
        public string Integrate { get; set; }
        [XmlAttribute("releaseType")]
        public string ReleaseType { get; set; }
        [XmlAttribute("restart")]
        public string Restart { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }
        [XmlElement("customInformation", Namespace = XmlNamespaces.AssemblyV3)]
        public CustomInformation CustomInformation { get; set; }
        [XmlElement("installerAssembly")]
        public InstallerAssembly InstallerAssembly { get; set; }
        [XmlElement("packageExtended", Namespace = XmlNamespaces.AssemblyV3)]
        public ExtendedPackage ExtendePackage { get; set; }
        [XmlElement("parent")]
        public Parent Parent { get; set; }
        [XmlElement("update")]
        public Update[] Updates { get; set; }

        private AssemblyIdentity _assemblyIdentity;
    }
}
