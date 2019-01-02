using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class CounterSet
    {
        [XmlElement("counter")]
        public Counter[] Counters { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("descriptionID")]
        public uint DescriptionID { get; set; }
        [XmlAttribute("guid")]
        public Guid UniqueId { get; set; }
        [XmlAttribute("instances")]
        public string Instances { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("nameID")]
        public uint NameID { get; set; }
        [XmlArray("structs"),
            XmlArrayItem(ElementName = "struct", Type = typeof(PerformanceCounterStructure))]
        public PerformanceCounterStructure[] PerformanceCounterStructures { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("uri")]
        public string URI { get; set; }
    }
}
