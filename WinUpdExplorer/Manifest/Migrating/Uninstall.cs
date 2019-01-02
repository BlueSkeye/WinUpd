using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Uninstall
    {
        [XmlElement("migXml", Namespace = XmlNamespaces.Empty)]
        public MigrationXml Xml { get; set; }
    }
}
