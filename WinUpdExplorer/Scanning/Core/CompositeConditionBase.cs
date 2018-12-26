using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class CompositeConditionBase
    {
        [XmlElement("CbsPackageInstalledByIdentity")]
        public CbsPackageInstalledByIdentityCondition[] CbsPackageInstalledByIdentities { get; set; }
        [XmlElement("b.FileExists")]
        public FileExistsCondition[] FilesExist { get; set; }
        [XmlElement("b.FileExistsPrependRegSz")]
        public FileVersionPrependRegSzCondition[] FileExistPrependRegSz { get; set; }
        [XmlElement("b.FileVersion")]
        public FileVersionCondition[] FileVersion { get; set; }
        [XmlElement("b.FileVersionPrependRegSz")]
        public FileVersionPrependRegSzCondition[] FileVersionPrependRegSz { get; set; }
        [XmlElement("b.LicenseDword")]
        public LicenceDwordCondition[] LicenceDword { get; set; }
        [XmlElement("b.MuiInstalled")]
        public MuiInstalled[] MuiInstalled { get; set; }
        [XmlElement("m.MsiFeatureInstalledForProduct")]
        public MsiFeatureInstalledForProductCondition[] MsiFeaturesInstalledForProducts { get; set; }
        [XmlElement("m.MsiProductInstalled")]
        public MsiProductInstalledCondition[] MsiProductInstalled { get; set; }
        [XmlElement("b.Processor")]
        public ProcessorCondition Processor { get; set; }
        [XmlElement("b.RegDword")]
        public RegDwordCondition[] RegDword { get; set; }
        [XmlElement("b.RegKeyExists")]
        public RegKeyExistsCondition[] RegKeyExists { get; set; }
        [XmlElement("b.RegKeyLoop")]
        public RegKeyLoopCondition RegKeyLoop { get; set; }
        [XmlElement("b.RegSz")]
        public RegSzCondition[] RegSz { get; set; }
        [XmlElement("b.RegSzToVersion")]
        public RegSzToVersionCondition[] RegSzToVersion { get; set; }
        [XmlElement("b.RegValueExists")]
        public RegValueExistsCondition[] RegValueExists { get; set; }
        [XmlElement("b.SystemMetric")]
        public SystemMetricValueCondition[] SystemMetrics { get; set; }
        [XmlElement("b.WindowsLanguage")]
        public WindowsLanguageCondition[] WindowsLanguages { get; set; }
        [XmlElement("b.WindowsVersion")]
        public WindowsVersionCondition[] WindowsVersion { get; set; }
        [XmlElement("b.WmiQuery")]
        public WmiQuery[] WmiQueries { get; set; }
    }
}
