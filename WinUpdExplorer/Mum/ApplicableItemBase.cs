using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class ApplicableItemBase
    {
        [XmlAttribute("elevate")]
        public string Elevate { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity[] AssemblyIdentities { get; set; }
    }
}
