using System.Collections.Generic;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.V1;

namespace MalikP.Aviation.Garmin.G1000.FPL.Generators
{
    public sealed class FlightPlanGenerator_V1 : AbstractFlightPlanGenerator, IFlightPlanGenerator_V1
    {
        public FlightPlanGenerator_V1(
            IWaypointRepository_V1 waypointRepository,
            IRouteGenerator_V1 routeGenerator)
            : base(waypointRepository, routeGenerator)
        {
        }

        protected override IFlightPlan GetFinalizedFlightPlan(IFlightPlanDescriptor flightPlanDescriptor, IEnumerable<KeyValuePair<int, IWaypoint>> waypoints, IRoute route)
        {
            return new FlightPlanType();
        }
    }
}