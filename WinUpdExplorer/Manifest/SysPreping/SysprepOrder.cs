using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class SysprepOrder
    {
        [XmlAttribute("order")]
        public string Order { get; set; }
    }
}
