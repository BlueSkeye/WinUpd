using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class MachineSpecific
    {
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MachineSpecificMigration XmlMigration { get; set; }
    }
}
