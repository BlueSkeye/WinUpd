﻿using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Mum
{
    public class Component
    {
        [XmlElement("assemblyIdentity")]
        public AssemblyIdentity AssemblyIdentity
        {
            get { return _assemblyIdentity; }
            set { _assemblyIdentity = AssemblyIdentityCatalog.Singleton.Register(value); }
        }

        private AssemblyIdentity _assemblyIdentity;
    }
}
