using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class RevisionReference
    {
        [XmlElement(ElementName = "Revision")]
        public IdReference Revision { get; set;}
    }
}

//OfflineSyncPackage/Updates/Update/SupersededBy/Revision
//OfflineSyncPackage/Updates/Update/SupersededBy/Revision/@Id
