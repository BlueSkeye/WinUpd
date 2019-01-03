using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    [XmlRoot(ElementName = "assembly", Namespace = XmlNamespaces.AssemblyV3)]
    public class AsmV3Assembly : AssemblyBase
    {
    }
}
