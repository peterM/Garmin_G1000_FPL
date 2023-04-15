using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot(ElementName = "extensions")]
    public partial class ExtensionsType
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
}