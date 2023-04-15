using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot(ElementName = "waypoint-type")]
    public enum WaypointTypeEnum
    {
        [XmlEnum("USER WAYPOINT")]
        USER_WAYPOINT,

        [XmlEnum("AIRPORT")]
        AIRPORT,

        [XmlEnum("NDB")]
        NDB,

        [XmlEnum("VOR")]
        VOR,

        [XmlEnum("INT")]
        INT,

        [XmlEnum("INT-VRP")]
        INT_VRP,
    }
}