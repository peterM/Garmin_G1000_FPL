using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models.Builders
{
    public sealed class FlightPlanDescriptorBuilder : AbstractBuilder<FlightPlanDescriptorBuilder, IFlightPlanDescriptor>
    {
        private IRouteDescriptor _routeDescriptor;

        private FlightPlanDescriptorBuilder()
            : base()
        {
        }
        public static FlightPlanDescriptorBuilder Create()
            => new FlightPlanDescriptorBuilder();

        public FlightPlanDescriptorBuilder WithRouteDescriptor(IRouteDescriptor routeDescriptor)
            => WithData(data => _routeDescriptor = data, routeDescriptor);

        public override IFlightPlanDescriptor Build()
            => new FlightPlanDescriptor(_routeDescriptor);
    }
}