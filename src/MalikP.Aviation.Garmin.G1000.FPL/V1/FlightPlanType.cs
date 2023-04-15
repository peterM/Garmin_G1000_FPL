using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot("flight-plan", Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1", IsNullable = false)]
    public partial class FlightPlanType
    {
    }
}