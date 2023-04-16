using System.Collections.Generic;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.V2;

namespace MalikP.Aviation.Garmin.G1000.FPL.Generators
{
    public sealed class FlightPlanGenerator_V2 : AbstractFlightPlanGenerator, IFlightPlanGenerator_V2
    {
        public FlightPlanGenerator_V2(
            IWaypointRepository_V2 waypointRepository,
            IRouteGenerator_V2 routeGenerator)
            : base(waypointRepository, routeGenerator)
        {
        }

        protected override IFlightPlan GetFinalizedFlightPlan(IFlightPlanDescriptor flightPlanDescriptor, IEnumerable<KeyValuePair<int, IWaypoint>> waypoints, IRoute route)
        {
            return new FlightPlanType();
        }
    }
}