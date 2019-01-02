using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Networking
{
    public class ClientDriver : DriverBase
    {
        [XmlAttribute("bindName")]
        public string BindName { get; set; }
    }
}
