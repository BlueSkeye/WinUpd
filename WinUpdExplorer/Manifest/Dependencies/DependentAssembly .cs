using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Dependencies
{
    public class DependentAssembly
    {
        [XmlAttribute("dependencyType")]
        public string DependencyType { get; set; }
        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity { get; set; }
        [XmlElement("bindingRedirect")]
        public BindingRedirect[] BindingRedirects { get; set; }
    }
}
