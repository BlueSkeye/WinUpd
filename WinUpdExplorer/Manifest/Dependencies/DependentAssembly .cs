using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Dependencies
{
    public class DependentAssembly
    {
        [XmlAttribute("dependencyType")]
        public string DependencyType { get; set; }
        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }
        [XmlElement("bindingRedirect")]
        public BindingRedirect[] BindingRedirects { get; set; }

        private AssemblyIdentity _assemblyIdentity;
    }
}
