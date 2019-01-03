using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Driver
    {
        [XmlAttribute("inf")]
        public string InfFile { get; set; }
        [XmlAttribute("ranking")]
        public string Ranking { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }

        private AssemblyIdentity _assemblyIdentity;
    }
}
