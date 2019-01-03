using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    /// <summary>Root class for ".manifest" files found in PSFX sub-directory with
    /// "urn:schemas-microsoft-com:asm.v1" namespace.</summary>
    [XmlRoot(ElementName = "assembly", Namespace = XmlNamespaces.AssemblyV1)]
    public class AsmV1Assembly : AssemblyBase
    {
        [XmlElement("noInheritable")]
        public string Noinheritable { get; set; }

        [XmlElement("file")]
        public Files.AsmV1FileDescriptor[] Files { get; set; }
    }
}
