﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Globalization
{
    public class Localization
    {
        [XmlElement("resources")]
        public Resources[] ResourceSets { get; set; }
    }
}
