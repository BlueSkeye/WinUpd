﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Firewalling
{
    public class FirewallGroupActivation
    {
        [XmlAttribute("action")]
        public string Action { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
