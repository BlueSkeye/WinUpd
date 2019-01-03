using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Files
{
    public class Typelib
    {
        [XmlAttribute("helpdir")]
        public string HelpDirectory { get; set; }
        [XmlAttribute("tlbid")]
        public Guid Id { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
