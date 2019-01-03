using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class ComClass
    {
        [XmlAttribute("clsid")]
        public Guid ClassId { get; set; }
        [XmlAttribute("progid")]
        public string VersionedProgramId { get; set; }
        [XmlElement("progid", Namespace = XmlNamespaces.AssemblyV1)]
        public string SimpleProgramId { get; set; }
        [XmlAttribute("threadingModel")]
        public string ThreadingModel { get; set; }
        [XmlAttribute("tlbid")]
        public Guid TypeLibId { get; set; }
    }
}
