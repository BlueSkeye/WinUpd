﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Container.Core
{
    public class AndInstalledCondition : CompositeConditionBase
    {
        [XmlElement("Not")]
        public NotInstalledCondition[] Not { get; set; }
        [XmlElement("Or")]
        public OrInstalledCondition[] Or { get; set; }
    }
}
