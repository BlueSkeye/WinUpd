using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Migration
    {
        [XmlAttribute("offlineApply")]
        public string OfflineApply { get; set; }
        [XmlAttribute("optimizePatterns")]
        public string OptimizePatterns { get; set; }
        [XmlAttribute("scope")]
        public string Scope { get; set; }
        [XmlAttribute("settingsVersion")]
        public string SettingsVersion { get; set; }

        [XmlElement("machineSpecific")]
        public MachineSpecific MachineSpecific { get; set; }
        [XmlElement("migrationDisplayID", Namespace = XmlNamespaces.AssemblyV3)]
        public string DisplayID { get; set; }
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MigrationXml XmlMigration { get; set; }
        [XmlArray("supportedComponents"),
            XmlArrayItem(ElementName = "supportedComponent", Type = typeof(SupportedComponent))]
        public SupportedComponent[] SupportedComponents { get; set; }
        [XmlElement("uninstall", Namespace = XmlNamespaces.AssemblyV3)]
        public Uninstall Uninstall { get; set; }
    }
}
