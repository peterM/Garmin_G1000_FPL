using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot("flight-plan", Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd", IsNullable = false)]
    public partial class FlightPlanType
    {
    }
}