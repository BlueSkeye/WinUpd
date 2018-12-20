using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    [XmlRoot(ElementName = "assembly", Namespace = Assembly.Namespace)]
    public class Assembly
    {
        /// <summary>Always 1.0</summary>
        [XmlAttribute("manifestVersion")]
        public string ManifestVersion { get; set; }

        [XmlElement("assemblyIdentity", IsNullable = false)]
        public AssemblyIdentity AssemblyIdentity { get; set; }

        [XmlElement("dependency", IsNullable = false)]
        public Dependency Dependency { get; set; }

        [XmlElement("deployment", IsNullable = true)]
        public string Deployment { get; set; }

        private const string Namespace = "urn:schemas-microsoft-com:asm.v3";
    }
}
