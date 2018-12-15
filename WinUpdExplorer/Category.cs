using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class Category
    {
        [XmlAttribute()]
        public string Id { get; set; }
        [XmlAttribute()]
        public string Type { get; set; }
    }
}

//OfflineSyncPackage/Updates/Update/Categories/Category
//OfflineSyncPackage/Updates/Update/Categories/Category/@Id
//OfflineSyncPackage/Updates/Update/Categories/Category/@Type
