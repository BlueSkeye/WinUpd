using System;
using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.CixManifest
{
    public class FileDescriptor
    {
        [XmlAttribute("attr")]
        public uint Attributes { get; set; }
        [XmlElement("Delta")]
        public Delta Delta { get; set; }
        [XmlElement("Hash")]
        public HashValue Hash { get; set; }
        [XmlAttribute("id")]
        public uint Id { get; set; }
        [XmlAttribute("length")]
        public uint Length { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("time")]
        public ulong Time { get; set; }

        /// <summary>Computed members.</summary>
        internal string Architecture { get; private set; }
        /// <summary>Probably not a checksum. Will rename it later.</summary>
        internal byte[] Checksum { get; private set; }
        internal bool Dual { get; private set; }
        internal bool IsCatalog { get; private set; }
        internal bool IsManifest { get; private set; }
        internal bool IsMum { get; private set; }
        // Mostly xx-yy. Some exceptions however such as qpc-ocm or qpc.ocsm
        internal string Language { get; private set; }
        internal string PublicKeyToken { get; private set; }
        /// <summary>For manifest and catalog files, the Name property is accurate and the RelativePath
        /// property is a null reference. For other files, this is the file path relative to the PSFX
        /// directory.</summary>
        internal string RelativePath { get; private set; }
        internal string SyntheticName { get; private set; }
        internal Version Version { get; private set; }

        internal void ParseFileName()
        {
            string fileName = this.Name;

            if (fileName.EndsWith(CatalogSuffix)) {
                IsCatalog = true;
                return;
            }
            if (fileName.EndsWith(MumSuffix)) {
                IsMum = true;
                return;
            }
            if (fileName.EndsWith(ManifestSuffix)) {
                IsManifest = true;
                fileName = fileName.Substring(0, fileName.Length - ManifestSuffix.Length);
            }
            else {
                int splitIndex = fileName.IndexOf('\\');
                if (0 >= splitIndex) {
                    throw new ApplicationException();
                }
                if (fileName.Length <= (1 + splitIndex)) {
                    throw new ApplicationException();
                }
                this.RelativePath = fileName.Substring(splitIndex + 1);
                fileName = fileName.Substring(0, splitIndex - 1);
            }
            string[] fileNameComponents = fileName.Split('_');
            int componentIndex = fileNameComponents.Length - 1;
            string checksumCandidate = fileNameComponents[componentIndex--];
            // TODO : Parse checksum candidate.
            Checksum = null;
            string languageCandidate = fileNameComponents[componentIndex--];
            if ("none" != languageCandidate) {
                Language = languageCandidate;
            }
            Version = Version.Parse(fileNameComponents[componentIndex--]);
            PublicKeyToken = fileNameComponents[componentIndex--];
            int nameComponentIndex;
            if ("dual" == fileNameComponents[1]) {
                Dual = true;
                nameComponentIndex = 2;
            }
            else {
                nameComponentIndex = 1;
            }
            Architecture = fileNameComponents[0];
            SyntheticName = fileNameComponents[nameComponentIndex];
            while (nameComponentIndex++ < componentIndex) {
                SyntheticName += "_" + fileNameComponents[nameComponentIndex];
            }
        }

        private const string CatalogSuffix = ".cat";
        private const string ManifestSuffix = ".manifest";
        private const string MumSuffix = ".mum";
    }
}
