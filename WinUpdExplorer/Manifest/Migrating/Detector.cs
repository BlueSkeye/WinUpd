using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Detector
    {
        [XmlElement("condition")]
        public string Condition { get; set; }
    }
}
