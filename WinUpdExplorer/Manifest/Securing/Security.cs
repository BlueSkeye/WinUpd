using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Securing
{
    public class Security
    {
        [XmlElement("accessControl")]
        public AccessControl AccessControl { get; set; }
    }
}
