﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest.Tasking
{
    public class ScheduledTaskSettings
    {
        [XmlElement("MultipleInstancesPolicy")]
        public string MultipleInstancesPolicy { get; set; }
        [XmlElement("DisallowStartIfOnBatteries")]
        public string DisallowStartIfOnBatteries { get; set; }
        [XmlElement("StopIfGoingOnBatteries")]
        public string StopIfGoingOnBatteries { get; set; }
        [XmlElement("AllowHardTerminate")]
        public string AllowHardTerminate { get; set; }
        [XmlElement("StartWhenAvailable")]
        public string StartWhenAvailable { get; set; }
        [XmlElement("RunOnlyIfNetworkAvailable")]
        public string RunOnlyIfNetworkAvailable { get; set; }
        [XmlElement("AllowStartOnDemand")]
        public string AllowStartOnDemand { get; set; }
        [XmlElement("Enabled")]
        public string Enabled { get; set; }
        [XmlElement("Hidden")]
        public string Hidden { get; set; }
        [XmlElement("RunOnlyIfIdle")]
        public string RunOnlyIfIdle { get; set; }
        [XmlElement("DisallowStartOnRemoteAppSession")]
        public string DisallowStartOnRemoteAppSession { get; set; }
        [XmlElement("UseUnifiedSchedulingEngine")]
        public string UseUnifiedSchedulingEngine { get; set; }
        [XmlElement("WakeToRun")]
        public string WakeToRun { get; set; }
        [XmlElement("ExecutionTimeLimit")]
        public string ExecutionTimeLimit { get; set; }
        [XmlElement("Priority")]
        public string Priority { get; set; }
    }
}
