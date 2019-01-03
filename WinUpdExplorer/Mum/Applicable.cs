using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Applicable
    {
        [XmlAttribute("disposition")]
        public string Disposition { get; set; }

        [XmlElement("updateComponent", Type = typeof(UpdateComponent))]
        public ApplicableItemBase[] UpdateComponents { get; set; }
        [XmlElement("updateDriver", Type = typeof(UpdateDriver))]
        public ApplicableItemBase[] UpdateDrivers { get; set; }
    }
}
