using System;
using System.Xml.Serialization;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot(ElementName = "waypoint")]
    public partial class WaypointType : IWaypoint
    {
        public void AddToRoute<T>(T route)
            where T : IRoute
        {
            if (route is RouteType rt)
            {
                AddToRoute(rt);
            }
        }

        private void AddToRoute(RouteType rt)
        {
            rt.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = CountryCode,
                WaypointIdentifier = Identifier,
                WaypointType = Type
            });
        }
    }
}