using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Configuration
{
    public class Elements
    {
        [XmlArray("AutoProxy"),
            XmlArrayItem("AutoProxyListItem")]
        public AutoProxyListItem[] AutoProxyItems { get; set; }
    }
}
