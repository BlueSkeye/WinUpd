﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class InstalledCondition : CompositeConditionBase
    {
        [XmlElement("False")]
        public AlwaysFalseCondition AlwaysFalse { get; set; }
        [XmlElement("True")]
        public AlwaysTrueCondition AlwaysTrue { get; set; }
        [XmlElement("And")]
        public AndInstalledCondition And { get; set; }
        [XmlElement("Not")]
        public NotInstalledCondition Not { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition Or { get; set; }
    }
}
