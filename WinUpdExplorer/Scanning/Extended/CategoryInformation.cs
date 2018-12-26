using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Extended
{
    public class CategoryInformation
    {
        [XmlAttribute("CategoryType")]
        public string CategoryType { get; set; }
        [XmlAttribute("DisplayOrder")]
        public uint DisplayOrder { get; set; }
        [XmlAttribute("ExcludedByDefault")]
        public bool ExcludedByDefault { get; set; }
        [XmlAttribute("ProhibitsSubcategories")]
        public bool ProhibitsSubcategories { get; set; }
        [XmlAttribute("ProhibitsUpdates")]
        public bool ProhibitsUpdates { get; set; }
    }
}
