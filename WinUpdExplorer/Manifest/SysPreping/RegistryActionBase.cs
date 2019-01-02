using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class RegistryActionBase
    {
        [XmlAttribute("path")]
        public string Path { get; set; }
    }
}
