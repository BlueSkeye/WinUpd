using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    [XmlRoot(RootNodeName)]
    public class UpdateCoreDetails
    {

        internal const string RootNodeName = "Core";
    }
}
