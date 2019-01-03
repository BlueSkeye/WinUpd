using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class AsmV1FileDescriptor : FileDescriptorBase
    {
        [XmlElement("comClass")]
        public ComClass ComClass { get; set; }
        [XmlElement("comInterfaceProxyStub")]
        public ComInterfaceProxyStub ComInterfaceProxyStub { get; set; }
        [XmlElement("typelib")]
        public Typelib TypeLibrary { get; set; }
        [XmlElement("windowClass")]
        public WindowClass[] WindowClasses { get; set; }
    }
}
