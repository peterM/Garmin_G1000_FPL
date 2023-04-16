using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot("flight-plan", Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1", IsNullable = false)]
    public partial class FlightPlanType : IFlightPlan
    {
        public void AddRoute(IRoute route)
        {
            if (route is RouteType rt)
            {
                Route = rt;
            }
        }

        public void AddWaypoints(IEnumerable<KeyValuePair<int, IWaypoint>> waypoints)
        {
            var casted = waypoints?.OrderBy(d => d.Key)
                ?.Select(d => d.Value)
                ?.OfType<WaypointType>()
                ?.ToList();
            Waypoints.AddRange(casted);
        }

        public string AsXml(IFlightPlanSerializer flightPlanSerializer)
            => flightPlanSerializer?.SerializeToXml<FlightPlanType>(this);
    }
}