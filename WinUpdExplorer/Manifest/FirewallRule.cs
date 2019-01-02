using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Manifest
{
    public class FirewallRule
    {
        [XmlAttribute("action")]
        public string Action { get; set; }
        [XmlAttribute("active")]
        public string Active { get; set; }
        [XmlAttribute("binary")]
        public string Binary { get; set; }
        [XmlAttribute("desc")]
        public string Description { get; set; }
        [XmlAttribute("dir")]
        public string Direction { get; set; }
        [XmlAttribute("group")]
        public string Group { get; set; }
        [XmlAttribute("internalName")]
        public string InternalName { get; set; }
        [XmlAttribute("lport")]
        public string LocalPort { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("profile")]
        public string Profile { get; set; }
        [XmlAttribute("protocol")]
        public string Protocol { get; set; }
        [XmlAttribute("ra4")]
        public string RemoteAddressIPV4 { get; set; }
        [XmlAttribute("ra6")]
        public string RemoteAddressIPV6 { get; set; }
        [XmlAttribute("rport")]
        public string RemotePort { get; set; }
        [XmlAttribute("svc")]
        public string Service { get; set; }
        [XmlAttribute("ttk")]
        public string TTK { get; set; }
    }

    /// <summary>Because once they screwed up and didn't notice XML is case sensitive.</summary>
    public class laxistFirewallRule : FirewallRule
    {
        [XmlAttribute("Action")]
        public string _1 { get { return base.Action; } set { base.Action = value; } }
        [XmlAttribute("Active")]
        public string _2 { get { return base.Active; } set { base.Active = value; } }
        [XmlAttribute("Binary")]
        public string _3 { get { return base.Binary; } set { base.Binary = value; } }
        [XmlAttribute("Desc")]
        public string _4 { get { return base.Description; } set { base.Description = value; } }
        [XmlAttribute("Dir")]
        public string _5 { get { return base.Direction; } set { base.Direction = value; } }
        [XmlAttribute("Group")]
        public string _6 { get { return base.Group; } set { base.Group = value; } }
        [XmlAttribute("InternalName")]
        public string _7 { get { return base.InternalName; } set { base.InternalName = value; } }
        [XmlAttribute("LPort")]
        public string _8 { get { return base.LocalPort; } set { base.LocalPort = value; } }
        [XmlAttribute("Name")]
        public string _9 { get { return base.Name; } set { base.Name = value; } }
        [XmlAttribute("Profile")]
        public string _13 { get { return base.Profile; } set { base.Profile = value; } }
        [XmlAttribute("Protocol")]
        public string _10 { get { return base.Protocol; } set { base.Protocol = value; } }
        [XmlAttribute("RA4")]
        public string _15 { get { return base.RemoteAddressIPV4; } set { base.RemoteAddressIPV4 = value; } }
        [XmlAttribute("RA6")]
        public string _16 { get { return base.RemoteAddressIPV6; } set { base.RemoteAddressIPV6 = value; } }
        [XmlAttribute("RPort")]
        public string _12 { get { return base.RemotePort; } set { base.RemotePort = value; } }
        [XmlAttribute("Svc")]
        public string _11 { get { return base.Service; } set { base.Service = value; } }
        [XmlAttribute("TTK")]
        public string _14 { get { return base.TTK; } set { base.TTK = value; } }
    }
}
