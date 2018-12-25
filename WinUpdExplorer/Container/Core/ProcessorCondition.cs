using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class ProcessorCondition
    {
        [XmlAttribute("Architecture")]
        public uint Architecture { get; set; }
    }
}
