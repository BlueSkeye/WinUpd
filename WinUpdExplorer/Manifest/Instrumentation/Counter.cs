using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class Counter
    {
        [XmlAttribute("defaultScale")]
        public int DefaultScale { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("descriptionID")]
        public uint DescriptionId { get; set; }
        [XmlAttribute("detailLevel")]
        public string DetailLevel { get; set; }
        [XmlAttribute("field")]
        public string Field { get; set; }
        [XmlAttribute("id")]
        public uint Id { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("nameID")]
        public uint NameId { get; set; }
        [XmlAttribute("struct")]
        public string Structure { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("type")]
        public string type { get; set; }
        [XmlAttribute("uri")]
        public string URI { get; set; }
    }
}
