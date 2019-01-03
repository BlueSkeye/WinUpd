using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Parent
    {
        [XmlAttribute("buildCompare")]
        public string BuildComparer { get; set; }
        [XmlAttribute("disposition")]
        public string Disposition { get; set; }
        [XmlAttribute("integrate")]
        public string Integrate { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity[] AssemblyIdentities { get; set; }
        [XmlElement("parent")]
        public Parent _Parent { get; set; }
    }
}
