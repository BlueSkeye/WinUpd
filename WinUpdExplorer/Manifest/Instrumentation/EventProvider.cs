using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class EventProvider
    {
        [XmlAttribute("guid")]
        public Guid Guid { get; set; }
        [XmlAttribute("message")]
        public string Message { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("messageFileName")]
        public string MessageFileName { get; set; }
        [XmlAttribute("parameterFileName")]
        public string ParameterFileName { get; set; }
        [XmlAttribute("resourceFileName")]
        public string ResourceFileName { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }

        [XmlArray("channels"),
            XmlArrayItem(ElementName = "importChannel", Type = typeof(ImportChannel)),
            XmlArrayItem(ElementName = "channel", Type = typeof(Channel))]
        public ChannelBase[] ImportChannels { get; set; }
    }
}
