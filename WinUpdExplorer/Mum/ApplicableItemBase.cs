using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class ApplicableItemBase
    {
        [XmlAttribute("elevate")]
        public string Elevate { get; set; }

        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity[] AssemblyIdentities
        {
            get { return _assemblyIdentities; }
            set
            {
                _assemblyIdentities = value;
                if (null != value) {
                    int count = value.Length;
                    for(int index = 0; index < count; index++) {
                        value[index] = AssemblyIdentityCatalog.Singleton.Register(value[index]);
                    }
                }
            }
        }

        private AssemblyIdentity[] _assemblyIdentities;
    }
}
