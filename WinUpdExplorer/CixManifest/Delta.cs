﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.CixManifest
{
    public class Delta
    {
        [XmlElement("Basis")]
        public Basis Basis { get; set; }
        [XmlElement("Source")]
        public Source Source { get; set; }
    }
}
