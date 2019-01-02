using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class FileActionBase
    {
        [XmlAttribute("path")]
        public string Path { get; set; }
    }
}
