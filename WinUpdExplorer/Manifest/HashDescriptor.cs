using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class HashDescriptor
    {
        [XmlElement("DigestMethod", Namespace = XmlNamespaces.Dsig)]
        public DigestMethod DigestMethod { get; set; }
        /// <summary>Base64 encoded digest value.</summary>
        [XmlElement("DigestValue", Namespace = XmlNamespaces.Dsig)]
        public string DigestValue { get; set; }
        [XmlArray("Transforms", Namespace = XmlNamespaces.Dsig),
            XmlArrayItem(ElementName = "Transform", Namespace = XmlNamespaces.Dsig, Type = typeof(Transformation))]
        public Transformation[] Transformations { get; set; }
    }
}
