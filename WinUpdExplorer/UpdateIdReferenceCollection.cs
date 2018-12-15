using System.Xml.Serialization;

namespace WinUpdExplorer
{
    public class UpdateIdReferenceCollection
    {
        [XmlArray(ElementName = "UpdateId")]
        public UpdateIdReference[] UpdateIds { get; set; }
    }
}
