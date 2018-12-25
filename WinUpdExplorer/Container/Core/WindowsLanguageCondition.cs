using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class WindowsLanguageCondition
    {
        [XmlAttribute("Language")]
        public string Language { get; set; }
    }
}
