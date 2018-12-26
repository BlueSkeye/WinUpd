using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Packaging
{
    public class FileDescriptor
    {
        /// <summary>Decimal code of the file attribute as defined in :
        /// https://docs.microsoft.com/fr-fr/windows/desktop/api/fileapi/nf-fileapi-setfileattributesa
        /// </summary>
        [XmlAttribute("attr")]
        public string Attributes { get; set; }
        [XmlElement("Delta")]
        public Delta Delta { get; set; }
        [XmlElement("Hash")]
        public HashValue Hash { get; set; }

        /// <summary>A number identifying the source file in the update package (it is just an index
        /// number).</summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>Target file length in bytes.</summary>
        [XmlAttribute("length")]
        public string Length { get; set; }

        /// <summary>Target file name, including extension.</summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>A 64-bit time stamp. Shows Win32 FILETIME values count 100-nanosecond intervals
        /// since January 1, 1600 UTC. More info:
        /// https://blogs.msdn.microsoft.com/oldnewthing/20030905-02/?p=42653
        /// </summary>
        [XmlAttribute("time")]
        public string Time { get; set; }
    }
}
