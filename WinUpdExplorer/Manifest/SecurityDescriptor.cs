﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class SecurityDescriptor
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
