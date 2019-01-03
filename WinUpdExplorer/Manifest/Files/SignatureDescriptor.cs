using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class SignatureDescriptor
    {
        [XmlAttribute("DRMLevel")]
        public uint DRMLevel { get; set; }
        [XmlAttribute("pageHash")]
        public bool PageHash { get; set; }
        [XmlAttribute("PETrust")]
        public bool PETrust { get; set; }
    }
}
