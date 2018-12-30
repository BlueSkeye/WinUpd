using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class Environment
    {
        [XmlElement("variable")]
        public Variable[] Variables { get; set; }
    }
}
