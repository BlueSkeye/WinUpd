﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class MsiFeatureInstalledForProductCondition
    {
        [XmlElement("m.Feature")]
        public string Feature { get; set; }
        [XmlElement("m.Product")]
        public Guid[] Products { get; set; }
    }
}
