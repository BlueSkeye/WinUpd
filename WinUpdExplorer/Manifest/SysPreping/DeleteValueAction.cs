using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class DeleteValueAction : RegistryActionBase
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
