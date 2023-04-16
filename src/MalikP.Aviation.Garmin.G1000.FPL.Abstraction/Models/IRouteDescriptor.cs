using System.Collections.Generic;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IRouteDescriptor
    {
        IReadOnlyDictionary<int, IWaypointDescriptor> Waypoints { get; }

        public string RouteName { get; }

        public string RouteDescription { get; }

        public int FlightPlanIndex { get; }
    }
}