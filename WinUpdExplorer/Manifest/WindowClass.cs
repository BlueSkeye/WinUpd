using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class WindowClass
    {
        [XmlAttribute("versioned")]
        public string Versioned { get; set; }

        [XmlText()]
        public string Class { get; set; }
    }
}
