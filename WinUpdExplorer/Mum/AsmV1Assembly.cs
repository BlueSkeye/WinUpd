using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    [XmlRoot(ElementName = "assembly", Namespace = XmlNamespaces.AssemblyV1)]
    public class AsmV1Assembly : AssemblyBase
    {
    }
}
