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
        public AssemblyIdentity[] AssemblyIdentities
        {
            get { return _assemblyIdentities; }
            set
            {
                _assemblyIdentities = value;
                if (null != value)
                {
                    int count = value.Length;
                    for (int index = 0; index < count; index++)
                    {
                        value[index] = AssemblyIdentityCatalog.Singleton.Register(value[index]);
                    }
                }
            }
        }
        [XmlElement("parent")]
        public Parent _Parent { get; set; }

        private AssemblyIdentity[] _assemblyIdentities;
    }
}
