using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    /// <summary>Root class for ".manifest" files found in PSFX sub-directory with
    /// "urn:schemas-microsoft-com:asm.v3" namespace.</summary>
    [XmlRoot(ElementName = "assembly", Namespace = XmlNamespaces.AssemblyV3)]
    public class AsmV3Assembly : AssemblyBase
    {
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute("isolated")]
        public bool Isolated { get; set; }

        [XmlElement("bfsvc", Namespace = XmlNamespaces.AssemblyV3)]
        public BfService BfService { get; set; }
        [XmlElement("configuration")]
        public Configuration.AssemblyConfiguration Configuration { get; set; }
        [XmlElement("deconstructionTool")]
        public DeconstructionTool DeconstructionTool { get; set; }
        [XmlElement("deployment", IsNullable = true)]
        public string Deployment { get; set; }
        [XmlArray("directories"),
            XmlArrayItem(ElementName = "directory", Type = typeof(Files.Directory))]
        public Files.Directory[] Directories { get; set; }
        [XmlElement("file")]
        public Files.AsmV3FileDescriptor[] Files { get; set; }
        [XmlElement("firewallGroupActivation",Namespace = XmlNamespaces.AssemblyV3)]
        public Firewalling.FirewallGroupActivation FirewallGroupActivation { get; set; }
        [XmlElement("firewallRule", Namespace = XmlNamespaces.AssemblyV3)]
        public Firewalling.laxistFirewallRule[] FirewallRules { get; set; }
        [XmlElement("fveUpdateAI", Namespace = XmlNamespaces.AssemblyV3)]
        public FveUpdateAI FveUpdateAI { get; set; }
        [XmlArray("genericCommands"),
            XmlArrayItem(ElementName = "genericCommand", Type = typeof(GenericCommand))]
        public GenericCommand[] GenericCommands { get; set; }
        [XmlElement("HTTPAI")]
        public HTTPAI HTTPAI { get; set; }
        [XmlElement("imaging")]
        public SysPreping.Imaging Imaging { get; set; }
        [XmlElement("instrumentation")]
        public Instrumentation.Instrumentation Instrumentation { get; set; }
        [XmlElement("localization")]
        public Globalization.Localization Localization { get; set; }
        [XmlElement("migration")]
        public Migrating.Migration Migration { get; set; }
        [XmlElement("mof")]
        public MofDefinition[] Mof { get; set; }
        [XmlElement("networkComponents")]
        public Networking.NetworkComponents NetworkComponents { get; set; }
        [XmlArray("registryKeys"),
            XmlArrayItem(ElementName = "registryKey", Type = typeof(Registry.RegistryKey))]
        public Registry.RegistryKey[] RegistryKeys { get; set; }
        [XmlElement("satelliteCategory")]
        public SatelliteCategory SatelliteCategory { get; set; }
        [XmlElement("taskScheduler", Namespace = XmlNamespaces.AssemblyV3)]
        public Tasking.TaskScheduler TaskScheduler { get; set; }
        [XmlElement("timezoneAI", Namespace = XmlNamespaces.AssemblyV3)]
        // TODO : Make this a class once we know the members.
        public string TimezoneAI { get; set; }
        [XmlElement("timezoneresourceAI", Namespace = XmlNamespaces.AssemblyV3)]
        // TODO : Make this a class once we know the members.
        public string TimezoneresourceAI { get; set; }
        [XmlElement("trustInfo")]
        public Securing.TrustInfo TrustInfo { get; set; }
        [XmlArray("unattendActions"),
            XmlArrayItem(ElementName = "unattendAction", Type = typeof(UnattendAction), Namespace = XmlNamespaces.AssemblyV3)]
        public UnattendAction[] UnattendActions { get; set; }
    }
}
