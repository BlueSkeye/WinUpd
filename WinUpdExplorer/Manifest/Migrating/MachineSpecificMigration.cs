﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Migrating
{
    public class MachineSpecificMigration
    {
        [XmlArray("detects"),
            XmlArrayItem(ElementName = "detect", Type = typeof(Detector))]
        public Detector[] Detect { get; set; }
        [XmlElement("environment")]
        public Environment Environment { get; set; }
        [XmlElement("plugin")]
        public Plugin Plugin { get; set; }
        [XmlElement("rules")]
        public RuleSet[] Rules { get; set; }
    }
}
