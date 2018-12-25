using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class CbsPackageInstalledByIdentityCondition
    {
        [XmlAttribute("PackageIdentity")]
        public string PackageIdentity { get; set; }
    }
}
