using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class ChannelBase
    {
        [XmlAttribute("chid")]
        public string ChannelId { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
