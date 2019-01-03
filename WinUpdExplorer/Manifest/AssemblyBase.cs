using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class AssemblyBase
    {
        [XmlElement("assemblyIdentity", IsNullable = false)]
        public AssemblyIdentity AssemblyIdentity { get; set; }
        [XmlAttribute("copyright", Namespace = XmlNamespaces.AssemblyV3)]
        public string Copyright { get; set; }
        /// <summary>Always 1.0. Useless for namespace disambiguation.</summary>
        [XmlAttribute("manifestVersion")]
        public string ManifestVersion { get; set; }

        [XmlElement("dependency", IsNullable = false)]
        public Dependencies.Dependency[] Dependency { get; set; }
        [XmlArray("memberships", Namespace = XmlNamespaces.AssemblyV3),
            XmlArrayItem(ElementName = "categoryMembership", Type = typeof(Categoryzing.Membership))]
        public Categoryzing.Membership[] CategoryMemberships { get; set; }
    }
}
