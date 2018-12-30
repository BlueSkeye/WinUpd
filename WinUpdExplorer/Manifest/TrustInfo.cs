using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class TrustInfo
    {
        [XmlElement("security")]
        public Security Security { get; set; }
    }
}
