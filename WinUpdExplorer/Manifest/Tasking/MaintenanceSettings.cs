using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class MaintenanceSettings
    {
        [XmlElement("Deadline")]
        public string Deadline { get; set; }
        [XmlElement("Exclusive")]
        public bool Exclusive { get; set; }
        [XmlElement("Period")]
        public string Period { get; set; }
    }
}
