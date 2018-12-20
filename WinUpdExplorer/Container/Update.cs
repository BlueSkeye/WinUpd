using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class Update
    {
        [XmlAttribute()]
        public string CreationDate { get; set; }
        [XmlAttribute()]
        public string DefaultLanguage { get; set; }
        [XmlAttribute("DeploymentAction")]
        public _DeploymentAction DeploymentAction { get; set; }
        [XmlAttribute()]
        public string DownloadPriority { get; set; }
        [XmlAttribute("IsBundle")]
        public bool IsBundle { get; set; }
        [XmlAttribute("IsLeaf")]
        public bool IsLeaf { get; set; }
        [XmlAttribute("IsSoftware")]
        public bool IsSoftware { get; set; }
        [XmlAttribute("RevisionId")]
        public uint RevisionId { get; set; }
        [XmlAttribute("RevisionNumber")]
        public uint RevisionNumber { get; set; }
        [XmlAttribute("UpdateId")]
        public Guid UpdateId { get; set; }
        [XmlElement("BundledBy")]
        public Bundler BundledBy { get; set; }
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

        public enum _DeploymentAction
        {
            Undefined = 0,
            Bundle,
            Evaluate,
        }
    }
}