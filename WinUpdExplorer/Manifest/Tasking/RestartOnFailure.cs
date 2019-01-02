using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class RestartOnFailure
    {
        [XmlElement("Count")]
        public uint Count { get; set; }
        [XmlElement("Interval")]
        public string Interval { get; set; }
    }
}
