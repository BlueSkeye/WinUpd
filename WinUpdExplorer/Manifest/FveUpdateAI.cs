using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FveUpdateAI
    {
        [XmlAttribute("fveCommand")]
        public string FveCommand { get; set; }
    }
}
