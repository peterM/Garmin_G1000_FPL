using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models
{
    public sealed class FlightPlanDescriptor : IFlightPlanDescriptor
    {
        public FlightPlanDescriptor(IRouteDescriptor route)
        {
            Route = route;
        }

        public IRouteDescriptor Route { get; }
    }
}