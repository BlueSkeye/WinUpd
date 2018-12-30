using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class SupportedComponent
    {
        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity { get; set; }
        [XmlElement("machineSpecific")]
        public MachineSpecific MachineSpecific { get; set; }
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MachineSpecificMigration XmlMigration { get; set; }
        [XmlElement("supportedComponentIdentity", Namespace = XmlNamespaces.AssemblyV3)]
        public SupportedComponentIdentity SupportedComponentIdentity { get; set; }
    }
}
