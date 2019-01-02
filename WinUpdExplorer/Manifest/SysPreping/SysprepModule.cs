using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.SysPreping
{
    public class SysprepModule
    {
        [XmlAttribute("methodName")]
        public string MethodName { get; set; }
        [XmlAttribute("moduleName")]
        public string ModuleName { get; set; }
        [XmlAttribute("moduleType")]
        public string ModuleType { get; set; }
    }
}
