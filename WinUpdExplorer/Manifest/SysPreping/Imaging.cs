using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class Imaging
    {
        [XmlElement("sysprepInformation")]
        public SysprepInformation SysprepInformation { get; set; }
    }
}
