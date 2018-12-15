using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class Update
    {
        [XmlAttribute()]
        public string CreationDate { get; set; }
        [XmlAttribute()]
        public string DefaultLanguage { get; set; }
        [XmlAttribute()]
        public string DeploymentAction { get; set; }
        [XmlAttribute()]
        public string DownloadPriority { get; set; }
        [XmlAttribute()]
        public string IsBundle { get; set; }
        [XmlAttribute()]
        public string IsLeaf { get; set; }
        [XmlAttribute()]
        public string IsSoftware { get; set; }
        [XmlAttribute()]
        public string RevisionId { get; set; }
        [XmlAttribute()]
        public string RevisionNumber { get; set; }
        [XmlAttribute()]
        public string UpdateId { get; set; }
        [XmlElement("BundledBy")]
        public RevisionReference BundledBy { get; set; }
        [XmlArray("Categories")]
        public Category[] Categories { get; set; }
        [XmlArray("EulaFiles"),
            XmlArrayItem(ElementName = "File", Type = typeof(LanguageBoundReference))]
        public LanguageBoundReference[] EulaFiles { get; set; }
        [XmlArray("Languages"),
            XmlArrayItem(ElementName = "Language", Type = typeof(NamedItem))]
        public NamedItem[] Languages { get; set; }
        [XmlArray("PayloadFiles"),
            XmlArrayItem(ElementName = "File", Type = typeof(IdReference))]
        public IdReference[] PayloadFiles { get; set; }
        [XmlArray("Prerequisites"),
            XmlArrayItem(ElementName = "Or", Type = typeof(UpdateIdReferenceCollection)),
            XmlArrayItem(ElementName = "UpdateId", Type = typeof(UpdateIdReference))]
        public object[] Prerequisites { get; set; }
    }
}
    //OfflineSyncPackage/Updates/Update

    //OfflineSyncPackage/Updates/Update/BundledBy

    //OfflineSyncPackage/Updates/Update/Categories

    //OfflineSyncPackage/Updates/Update/EulaFiles
    //OfflineSyncPackage/Updates/Update/EulaFiles/File
    //OfflineSyncPackage/Updates/Update/EulaFiles/File/@Id
    //OfflineSyncPackage/Updates/Update/EulaFiles/File/Language
    //OfflineSyncPackage/Updates/Update/EulaFiles/File/Language/@Name

    //OfflineSyncPackage/Updates/Update/Languages
    //OfflineSyncPackage/Updates/Update/Languages/Language
    //OfflineSyncPackage/Updates/Update/Languages/Language/@Name

    //OfflineSyncPackage/Updates/Update/PayloadFiles
    //OfflineSyncPackage/Updates/Update/PayloadFiles/File
    //OfflineSyncPackage/Updates/Update/PayloadFiles/File/@Id

    //OfflineSyncPackage/Updates/Update/Prerequisites
    //OfflineSyncPackage/Updates/Update/Prerequisites/Or
    //OfflineSyncPackage/Updates/Update/Prerequisites/Or/UpdateId
    //OfflineSyncPackage/Updates/Update/Prerequisites/Or/UpdateId/@Id
    //OfflineSyncPackage/Updates/Update/Prerequisites/UpdateId
    //OfflineSyncPackage/Updates/Update/Prerequisites/UpdateId/@Id

    //OfflineSyncPackage/Updates/Update/SupersededBy
