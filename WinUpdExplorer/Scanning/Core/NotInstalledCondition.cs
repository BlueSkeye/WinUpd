using System.Xml;
using System.Xml.Serialization;

namespace WinUpdExplorer.Scanning.Core
{
    public class NotInstalledCondition : LogicalCompositeConditionBase
    {
        // Intentionally left empty.
        // REMARKS : Is a <Not> element really expected inside another <And> element ?
    }
}
