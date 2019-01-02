using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Publishing
    {
        [XmlElement("bufferSize")]
        public uint BufferSize { get; set; }
        [XmlElement("clockType")]
        public string ClockType { get; set; }
        [XmlElement("keywords")]
        public string Keywords { get; set; }
        [XmlElement("level")]
        public string Level { get; set; }
        [XmlElement("maxBuffers")]
        public uint MaxBuffers { get; set; }
    }
}
