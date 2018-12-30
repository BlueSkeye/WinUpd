using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class ConfigurationSchema
    {
        [XmlAnyElement()]
        public object[] Elements { get; set; }
        [XmlAnyAttribute()]
        public XmlAttribute[] Attributes { get; set; }
    }
}
