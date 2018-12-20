using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container
{
    public class Category
    {
        [XmlAttribute("Id")]
        public Guid Id { get; set; }
        [XmlAttribute("Type")]
        public _Type Type { get; set; }

        public enum _Type
        {
            Unknown = 0,
            Company,
            Product,
            ProductFamily,
            UpdateClassification,
        }
    }
}
