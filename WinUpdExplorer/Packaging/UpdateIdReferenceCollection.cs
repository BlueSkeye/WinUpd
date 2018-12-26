using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class UpdateIdReferenceCollection
    {
        [XmlArray(ElementName = "UpdateId")]
        public UpdateIdReference[] UpdateIds { get; set; }
    }
}
