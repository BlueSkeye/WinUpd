using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Environment
    {
        [XmlAttribute("context")]
        public string Context { get; set; }
        [XmlElement("variable")]
        public Variable[] Variables { get; set; }
    }
}
