using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class Security
    {
        [XmlElement("accessControl")]
        public AccessControl AccessControl { get; set; }
    }
}
