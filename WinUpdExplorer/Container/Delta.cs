using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class Delta
    {
        [XmlElement("Basis", IsNullable = true)]
        public Basis Basis { get; set; }
        [XmlElement("Source")]
        public Source Source { get; set; }
    }
}
