using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Configuration
{
    public class Schema
    {
        [XmlAnyElement()]
        public object[] Elements { get; set; }
        [XmlAnyAttribute()]
        public XmlAttribute[] Attributes { get; set; }
    }
}
