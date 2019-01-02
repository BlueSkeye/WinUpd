using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Plugin
    {
        [XmlAttribute("classId")]
        public string ClassId { get; set; }
        [XmlAttribute("critical")]
        public string Critical { get; set; }
        [XmlAttribute("file")]
        public string File { get; set; }
        [XmlAttribute("offlineApply")]
        public string OfflineApply { get; set; }
    }
}
