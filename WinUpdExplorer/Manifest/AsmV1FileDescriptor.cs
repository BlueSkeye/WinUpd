using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class AsmV1FileDescriptor : FileDescriptorBase
    {
        [XmlElement("windowClass")]
        public WindowClass WindowClass { get; set; }
    }
}
