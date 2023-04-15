using System;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    /// <summary>
    /// RoutePointType -> 'waypoint-type'
    /// WaypointType -> 'type'
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
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

        [XmlEnum("FMS WAYPOINT")]
        FMS_WAYPOINT,

        [XmlEnum("LAT/LON")]
        LATITUDE_LONGITUDE,
    }
}