using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class SatelliteCategory
    {
        [XmlAttribute("discoverable")]
        public bool Discoverable { get; set; }
        [XmlElement("id")]
        public AssemblyIdentity Id
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }

        private AssemblyIdentity _assemblyIdentity;
    }
}
