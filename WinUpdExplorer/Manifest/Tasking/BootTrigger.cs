using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class BootTrigger : TriggerBase
    {
        [XmlElement("Delay")]
        public string Delay { get; set; }
    }
}
