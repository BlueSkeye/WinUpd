using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    [XmlRoot(RootNodeName)]
    public class UpdateCoreDetails
    {
        [XmlElement("ApplicabilityRules")]
        public ApplicabilityRuleCollection ApplicabilityRules { get; set; }
        [XmlElement("Properties")]
        public PropertyCollection Properties { get; set; }
        [XmlElement("Relationships")]
        public RelationshipCollection Relationships { get; set; }
        [XmlElement("UpdateIdentity")]
        public UpdateIdentity UpdateIdentity { get; set; }

        internal const string RootNodeName = "Core";
        internal const string AlternateNamespace = "http://nowhere.com";
    }
}
