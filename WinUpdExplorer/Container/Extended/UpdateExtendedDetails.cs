using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Extended
{
    [XmlRoot(RootNodeName)]
    public class UpdateExtendedDetails
    {
        [XmlElement("ExtendedProperties")]
        public ExtendedProperties ExtendedProperties { get; set; }
        [XmlElement("HandlerSpecificData")]
        public HandlerSpecificData HandlerSpecificData { get; set; }

        internal const string RootNodeName = "Extended";
    }
}
