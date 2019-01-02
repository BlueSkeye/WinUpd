using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class SysprepProvider
    {
        [XmlArray("fileActions"),
            XmlArrayItem(ElementName = "deleteFile", Type = typeof(DeleteFileAction))]
        public FileActionBase[] FileActions { get; set; }
        [XmlArray("registryActions"),
            XmlArrayItem(ElementName = "deleteKey", Type = typeof(DeleteKeyAction)),
            XmlArrayItem(ElementName = "deleteValue", Type = typeof(DeleteValueAction))]
        public RegistryActionBase[] RegistryActions { get; set; }
        [XmlAttribute("stage")]
        public string Stage { get; set; }
        [XmlElement("sysprepModule")]
        public SysprepModule[] SysprepModules { get; set; }
        [XmlElement("sysprepOrder")]
        public SysprepOrder SysprepOrder { get; set; }
    }
}
