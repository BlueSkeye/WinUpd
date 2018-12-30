using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class PerformanceCounter
    {
        [XmlAttribute("defaultScale")]
        public int DefaultScale { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("descriptionID")]
        public uint DescriptionID { get; set; }
        [XmlAttribute("detailLevel")]
        public string DetailLevel { get; set; }
        [XmlAttribute("field")]
        public string Field { get; set; }
        [XmlAttribute("id")]
        public uint Id { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("nameID")]
        public uint NameID { get; set; }
        [XmlAttribute("struct")]
        public string Struct { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("uri")]
        public string URI { get; set; }
    }
}
