using System;
using System.Collections.Generic;

namespace WinUpdExplorer
{
    internal class AssemblyIdentityCatalog : IEqualityComparer<AssemblyIdentity>
    {
        static AssemblyIdentityCatalog()
        {
            Singleton = new AssemblyIdentityCatalog();
        }

        private AssemblyIdentityCatalog()
        {
            _catalog = new Dictionary<AssemblyIdentity, AssemblyIdentity>(this);
            return;
        }

        internal uint ReuseCount { get; private set; }

        internal static AssemblyIdentityCatalog Singleton { get; private set; }

        internal uint UniqueCount
        {
            get { return (uint)_catalog.Count; }
        }

        /// <summary></summary>
        /// <param name="identity"></param>
        /// <returns>true if the <paramref name="identity"/> value has been substituted with an already
        /// registered instance.</returns>
        internal AssemblyIdentity Register(AssemblyIdentity identity)
        {
            if (null == identity) { return null; }
            AssemblyIdentity result;
            if (!_catalog.TryGetValue(identity, out result)) {
                _catalog.Add(identity, (result = identity));
            }
            else {
                ReuseCount++;
            }
            return result;
        }

        public bool Equals(AssemblyIdentity x, AssemblyIdentity y)
        {
            if ((null == x) || (null == y)) {
                throw new ApplicationException();
            }
            return (x.ProcessorArchitecture == y.ProcessorArchitecture)
                && (x.PublicKeyToken == y.PublicKeyToken)
                && (x.BuildType == y.BuildType)
                && (x.Language == y.Language)
                && (x.Name == y.Name)
                && (x.Type == y.Type)
                && (x.Version == y.Version)
                && (x.VersionScope == y.VersionScope);
        }

        public int GetHashCode(AssemblyIdentity x)
        {
            if (null == x) { throw new ArgumentNullException(); }
            return (x.ProcessorArchitecture ?? string.Empty).GetHashCode()
                ^ (x.PublicKeyToken ?? string.Empty).GetHashCode()
                ^ (x.BuildType ?? string.Empty).GetHashCode()
                ^ (x.Language ?? string.Empty).GetHashCode()
                ^ x.Name.GetHashCode()
                ^ (x.Type ?? string.Empty).GetHashCode()
                ^ (x.Version ?? string.Empty).GetHashCode()
                ^ (x.VersionScope ?? string.Empty).GetHashCode();
        }

        private Dictionary<AssemblyIdentity, AssemblyIdentity> _catalog;
    }
}
