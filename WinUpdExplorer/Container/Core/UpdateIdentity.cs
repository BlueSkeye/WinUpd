using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class UpdateIdentity
    {
        [XmlAttribute("RevisionNumber")]
        public uint RevisionNumber { get; set; }
        [XmlAttribute("UpdateID")]
        public Guid UpdateId { get; set; }
    }
}
