using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class Repetition
    {
        [XmlElement("Interval")]
        public string Interval { get; set; }
        [XmlElement("StopAtDurationEnd")]
        public bool StopAtDurationEnd { get; set; }
    }
}
