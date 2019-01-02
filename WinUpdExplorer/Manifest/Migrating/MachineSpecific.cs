using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class MachineSpecific
    {
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MigrationXml XmlMigration { get; set; }
        [XmlElement("migXml", Namespace = XmlNamespaces.AssemblyV3)]
        public MigrationXml XmlMigrationV3 { get; set; }
    }
}
