﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class PropertyCollection
    {
        [XmlAttribute("UpdateType")]
        public string UpdateType { get; set; }
    }
}
