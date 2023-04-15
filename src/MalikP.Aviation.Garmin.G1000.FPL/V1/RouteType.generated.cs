using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot(ElementName = "route")]
    public partial class RouteType
    {
        [XmlElement("route-name")]
        public string RouteName { get; set; }

        [XmlElement("route-description")]
        public string RouteDescription { get; set; }

        [XmlElement("flight-plan-index", DataType = "nonNegativeInteger")]
        public string FlightPlanIndex { get; set; }

        [XmlElement("route-point")]
        public RoutePointType[] RoutePoint { get; set; }

        [XmlElement("extensions")]
        public ExtensionsType Extensions { get; set; }
    }
}