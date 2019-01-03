using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Dependencies
{
    public class BindingRedirect
    {
        [XmlAttribute("newVersion")]
        public string NewVersion { get; set; }
        [XmlAttribute("oldVersion")]
        public string OldVersion { get; set; }

    }
}
