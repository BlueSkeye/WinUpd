using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class SysprepInformation
    {
        [XmlElement("sysprepProvider", Namespace = XmlNamespaces.AssemblyV3)]
        public SysprepProvider[] SysprepProviders { get; set; }
    }
}
