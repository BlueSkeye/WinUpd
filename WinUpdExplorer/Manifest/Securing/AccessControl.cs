using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Securing
{
    public class AccessControl
    {
        [XmlArray("securityDescriptorDefinitions"),
            XmlArrayItem(ElementName = "securityDescriptorDefinition", Type = typeof(SecurityDescriptorDefinition))]
        public SecurityDescriptorDefinition[] SecurityDescriptorDefinitions { get; set; }
    }
}
