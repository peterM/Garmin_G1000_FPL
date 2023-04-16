using System.Collections.Generic;
using System.Linq;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators
{
    public abstract class AbstractFlightPlanGenerator : IFlightPlanGenerator
    {
        private readonly IWaypointRepository _waypointRepository;
        private readonly IRouteGenerator _routeGenerator;

        protected AbstractFlightPlanGenerator(
            IWaypointRepository waypointRepository,
            IRouteGenerator routeGenerator)
        {
            _waypointRepository = waypointRepository;
            _routeGenerator = routeGenerator;
        }

        public IFlightPlan GetFlightPlan(IFlightPlanDescriptor flightPlanDescriptor)
            => GenerateFlightPlan(flightPlanDescriptor);

        private IFlightPlan GenerateFlightPlan(IFlightPlanDescriptor flightPlanDescriptor)
        {
            IEnumerable<KeyValuePair<int, IWaypoint>> waypoints = GetWaypoints(flightPlanDescriptor.Route);
            IRoute route = GetRoute(flightPlanDescriptor.Route);

            return GetFinalizedFlightPlan(flightPlanDescriptor, waypoints, route);
        }

        protected abstract IFlightPlan GetFinalizedFlightPlan(IFlightPlanDescriptor flightPlanDescriptor, IEnumerable<KeyValuePair<int, IWaypoint>> waypoints, IRoute route);

        protected virtual IRoute GetRoute(IRouteDescriptor route)
            => _routeGenerator.GetRoute(route);

        protected virtual IEnumerable<KeyValuePair<int, IWaypoint>> GetWaypoints(IRouteDescriptor route)
            => route?.Waypoints
                ?.Select(d => new KeyValuePair<int, IWaypoint>(d.Key, _waypointRepository?.GetWaypoint(d.Value)))
                ?.ToList();
    }
}