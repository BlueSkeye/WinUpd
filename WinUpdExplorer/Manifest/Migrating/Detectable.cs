using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Detectable
    {
        [XmlArray("detects"),
            XmlArrayItem(ElementName = "detect", Type = typeof(Detector))]
        public Detector[] Detect { get; set; }
    }
}
