using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class MsiProductInstalledCondition
    {
        [XmlAttribute("ExcludeVersionMax")]
        public bool ExcludeVersionMax { get; set; }
        [XmlAttribute("ExcludeVersionMin")]
        public bool ExcludeVersionMin { get; set; }
        [XmlAttribute("Language")]
        public uint Language { get; set; }
        [XmlAttribute("ProductCode")]
        public Guid ProductCode { get; set; }
        [XmlAttribute("VersionMax")]
        public string VersionMax { get; set; }
        [XmlAttribute("VersionMin")]
        public string VersionMin { get; set; }
    }
}
