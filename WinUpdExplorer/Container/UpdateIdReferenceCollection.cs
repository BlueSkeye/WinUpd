using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class UpdateIdReferenceCollection
    {
        [XmlArray(ElementName = "UpdateId")]
        public UpdateIdReference[] UpdateIds { get; set; }
    }
}
