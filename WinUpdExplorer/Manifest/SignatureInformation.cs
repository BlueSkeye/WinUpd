using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class SignatureInformation
    {
        [XmlElement("signatureDescriptor")]
        public SignatureDescriptor SignatureDescriptor { get; set; }
    }
}
