using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class SignatureDescriptor
    {
        [XmlAttribute("PETrust")]
        public bool PETrust { get; set; }
        [XmlAttribute("pageHash")]
        public bool PageHash { get; set; }
    }
}
