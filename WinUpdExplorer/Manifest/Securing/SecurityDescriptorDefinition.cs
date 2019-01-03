using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Securing
{
    public class SecurityDescriptorDefinition
    {
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("operationHint")]
        public string OperationHint { get; set; }
        [XmlAttribute("sddl")]
        public string SDDL { get; set; }
    }
}
