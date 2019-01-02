using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class NetworkComponents
    {
        [XmlElement("clientDriver")]
        public ClientDriver ClientDriver { get; set; }
        [XmlElement("filterDriver")]
        public FilterDriver FilterDriver { get; set; }
        [XmlElement("netAdapterDriver")]
        public NetworkAdapterDriver NetworkAdapterDriver { get; set; }
        [XmlElement("protocolDriver")]
        public ProtocolDriver[] ProtocolDrivers { get; set; }
    }
}
