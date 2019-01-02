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
        public MigrationXml XmlMigration { get; set; }
        [XmlElement("migXml")]
        public MigrationXml _1 { get { return XmlMigration; } set { XmlMigration = value; } }
        [XmlElement("supportedComponentIdentity", Namespace = XmlNamespaces.AssemblyV3)]
        public SupportedComponentIdentity SupportedComponentIdentity { get; set; }
    }
}
