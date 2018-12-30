using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Migration
    {
        [XmlAttribute("scope")]
        public string Scope { get; set; }
        [XmlAttribute("settingsVersion")]
        public string SettingsVersion { get; set; }

        [XmlElement("machineSpecific")]
        public MachineSpecific MachineSpecific { get; set; }
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MachineSpecificMigration XmlMigration { get; set; }
        [XmlArray("supportedComponents"),
            XmlArrayItem(ElementName = "supportedComponent", Type = typeof(SupportedComponent))]
        public SupportedComponent[] SupportedComponents { get; set; }
    }
}
