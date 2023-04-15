using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot(ElementName = "route-point")]
    public partial class RoutePointType
    {
        [XmlElement("waypoint-identifier")]
        public string WaypointIdentifier { get; set; }

        [XmlElement("waypoint-type")]
        public WaypointTypeEnum WaypointType { get; set; }

        [XmlElement("waypoint-country-code")]
        public string WaypointCountryCode { get; set; }

        [XmlElement("extensions")]
        public ExtensionsType Extensions { get; set; }
    }
}