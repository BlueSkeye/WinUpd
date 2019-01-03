using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class ExtendedPackage
    {
        [XmlAttribute("completelyOfflineCapable")]
        public string CompletelyOfflineCapable { get; set; }
        [XmlAttribute("packageSize")]
        public uint PackageSize { get; set; }
    }
}
