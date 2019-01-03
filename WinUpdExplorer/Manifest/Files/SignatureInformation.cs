using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class SignatureInformation
    {
        [XmlElement("signatureDescriptor")]
        public SignatureDescriptor[] SignatureDescriptors { get; set; }
    }
}
