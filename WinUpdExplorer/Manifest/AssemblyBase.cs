using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class AssemblyBase : AssemblyCommonBase
    {
        [XmlElement("dependency", IsNullable = false)]
        public Dependencies.Dependency[] Dependency { get; set; }
        [XmlArray("memberships", Namespace = XmlNamespaces.AssemblyV3),
            XmlArrayItem(ElementName = "categoryMembership", Type = typeof(Categoryzing.Membership))]
        public Categoryzing.Membership[] CategoryMemberships { get; set; }
    }
}
