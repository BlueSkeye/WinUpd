using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Instrumentation
{
    public class CounterProvider
    {
        [XmlAttribute("applicationIdentity")]
        public string ApplicationIdentity { get; set; }
        [XmlAttribute("providerGuid")]
        public Guid Id { get; set; }
        [XmlAttribute("providerType")]
        public string Type { get; set; }
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }

        [XmlElement("counterSet")]
        public CounterSet[] CounterSets { get; set; }
    }
}
