using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class AssemblyCommonBase
    {
        [XmlAttribute("copyright", Namespace = XmlNamespaces.AssemblyV3)]
        public string Copyright { get; set; }
        /// <summary>Always 1.0. Useless for namespace disambiguation.</summary>
        [XmlAttribute("manifestVersion")]
        public string ManifestVersion { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }

        private AssemblyIdentity _assemblyIdentity;
    }
}
