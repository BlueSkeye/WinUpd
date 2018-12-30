using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class RegistryKey
    {
        [XmlAttribute("keyName")]
        public string KeyName { get; set; }

        [XmlElement("overridable")]
        public OverridableRegistryKey Overriding { get; set; }
        [XmlElement("registryValue")]
        public RegistryValue[] RegistryValues { get; set; }
        [XmlElement("securityDescriptor")]
        public SecurityDescriptor SecurityDescriptor { get; set; }
    }
}
