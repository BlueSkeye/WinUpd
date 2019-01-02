using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class SignatureInformation
    {
        [XmlElement("signatureDescriptor")]
        public SignatureDescriptor[] SignatureDescriptors { get; set; }
    }
}
