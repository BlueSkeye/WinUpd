using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class AtLeastOneCondition
    {
        [XmlAttribute("IsCategory")]
        public bool IsCategory { get; set; }
        [XmlElement("UpdateIdentity")]
        public UpdateIdentity[] UpdateIdentity { get; set; }
    }
}
