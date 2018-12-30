using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class AssemblyConfiguration
    {
        [XmlElement("configurationSchema", Namespace = XmlNamespaces.AssemblyV3)]
        public ConfigurationSchema Schema { get; set; }
    }
}
