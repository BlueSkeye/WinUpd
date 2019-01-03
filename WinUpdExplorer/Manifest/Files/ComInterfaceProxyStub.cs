using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class ComInterfaceProxyStub
    {
        [XmlAttribute("iid")]
        public Guid InterfaceId { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("tlbid")]
        public Guid TypeLibraryId { get; set; }
    }
}
