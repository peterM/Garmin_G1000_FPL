using System.Collections.Generic;
using System.Linq;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models
{
    public sealed class RouteDescriptor : IRouteDescriptor
    {
        public RouteDescriptor(
            string routeName,
            string routeDescription,
            int flightPlanIndex,
            IEnumerable<IWaypointDescriptor> waypoints)
        {
            RouteName = routeName;
            RouteDescription = routeDescription;
            FlightPlanIndex = flightPlanIndex;
            Waypoints = waypoints?.ToList()
                ?.Select((item, index) => new KeyValuePair<int, IWaypointDescriptor>(index, item))
                ?.ToDictionary(d => d.Key, d => d.Value)
                ?? new Dictionary<int, IWaypointDescriptor>();
        }

        public IReadOnlyDictionary<int, IWaypointDescriptor> Waypoints { get; }

        public string RouteName { get; }

        public string RouteDescription { get; }

        public int FlightPlanIndex { get; }
    }
}