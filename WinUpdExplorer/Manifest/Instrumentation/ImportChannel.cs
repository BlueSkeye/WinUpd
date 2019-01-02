using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class ImportChannel : ChannelBase
    {
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
    }
}
