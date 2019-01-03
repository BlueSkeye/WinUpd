using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Categoryzing
{
    public class Membership
    {
        [XmlElement("categoryInstance")]
        public Instance[] CategoryInstances { get; set; }
        [XmlElement("id")]
        public MembershipId Id { get; set; }
    }
}
