using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class RegistryValue
    {
        [XmlAttribute("IEDownlevelValue")]
        public string IEDownlevelValue { get; set; }
        [XmlAttribute("mutable")]
        public bool Mutable { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("operationHint")]
        public string OperationHint { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("valueType")]
        public string ValueType { get; set; }
    }
}
