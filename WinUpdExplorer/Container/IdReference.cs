using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class IdReference
    {
        [XmlAttribute()]
        public string Id { get; set; }
    }

    public class UpdateIdReference
    {
        [XmlAttribute("Id")]
        public Guid Id { get; set; }
    }
}
