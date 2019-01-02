using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ComHandler : ActionBase
    {
        [XmlElement("ClassId")]
        public Guid ClassId { get; set; }
        [XmlElement("Data")]
        public string Data { get; set; }
    }
}
