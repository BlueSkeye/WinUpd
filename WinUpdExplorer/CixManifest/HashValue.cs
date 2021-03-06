﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.CixManifest
{
    public class HashValue
    {
        [XmlAttribute("alg")]
        public string Algorithm { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
