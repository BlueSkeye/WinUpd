using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
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

        internal IEnumerable<uint> EnumerateUpdateIds(bool includeBundles = false)
        {
            foreach(Update scannedUpdate in Updates) {
                if (!includeBundles && scannedUpdate.IsBundle) {
                    continue;
                }
                yield return scannedUpdate.RevisionId;
            }
            yield break;
        }

        public const string Namespace = "http://schemas.microsoft.com/msus/2004/02/OfflineSync";
    }
}
