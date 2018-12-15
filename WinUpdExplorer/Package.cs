using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    [XmlRoot(ElementName = "OfflineSyncPackage", Namespace = Package.Namespace)]
    public class Package
    {
        [XmlAttribute()]
        public string CreationDate { get; set; }
        [XmlAttribute()]
        public string MinimumClientVersion { get; set; }
        [XmlAttribute()]
        public string PackageId { get; set; }
        [XmlAttribute()]
        public string PackageVersion { get; set; }
        [XmlAttribute()]
        public string ProtocolVersion { get; set; }
        [XmlAttribute()]
        public string SourceId { get; set; }
        [XmlArray("FileLocations")]
        public FileLocation[] FileLocations { get; set; }
        [XmlArray("Updates")]
        public Update[] Updates { get; set; }

        public const string Namespace = "http://schemas.microsoft.com/msus/2004/02/OfflineSync";
    }
}
//OfflineSyncPackage/FileLocations
//OfflineSyncPackage/FileLocations/FileLocation
//OfflineSyncPackage/FileLocations/FileLocation/@Id
//OfflineSyncPackage/FileLocations/FileLocation/@IsIncluded
//OfflineSyncPackage/FileLocations/FileLocation/@Url

//OfflineSyncPackage/Updates

