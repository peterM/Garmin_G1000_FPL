using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot("flight-plan", Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd", IsNullable = false)]
    public partial class FlightPlanType
    {
        [XmlElement("file-description")]
        public string FileDescription { get; set; }

        [XmlElement("author")]
        public PersonType Author { get; set; }

        [XmlElement(DataType = "anyURI", ElementName = "link")]
        public string Link { get; set; }

        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlIgnore]
        public bool CreatedSpecified { get; set; }

        [XmlArray("waypoint-table")]
        [XmlArrayItem("waypoint", IsNullable = false)]
        public WaypointType[] Waypoints { get; set; }

        [XmlElement("route")]
        public RouteType Route { get; set; }

        [XmlElement("extensions")]
        public ExtensionsType Extensions { get; set; }
    }
}