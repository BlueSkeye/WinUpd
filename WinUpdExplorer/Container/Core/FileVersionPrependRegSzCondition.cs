﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class FileVersionPrependRegSzCondition
    {
        [XmlAttribute("Comparison")]
        public string Comparison { get; set; }
        [XmlAttribute("Key")]
        public string Key { get; set; }
        [XmlAttribute("Path")]
        public string Path { get; set; }
        [XmlAttribute("Subkey")]
        public string Subkey { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
        [XmlAttribute("Version")]
        public string Version { get; set; }
    }
}
