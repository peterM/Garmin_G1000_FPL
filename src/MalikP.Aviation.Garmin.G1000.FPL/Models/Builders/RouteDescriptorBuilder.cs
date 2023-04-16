using System.Collections.Generic;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models.Builders
{
    public sealed class RouteDescriptorBuilder : AbstractBuilder<RouteDescriptorBuilder, IRouteDescriptor>
    {
        private string _routeName;
        private string _routeDescription;
        private int _routeFlightPlanIndex;

        private readonly IList<IWaypointDescriptor> _waypoints = new List<IWaypointDescriptor>();

        private RouteDescriptorBuilder()
            : base()
        {
        }

        public static RouteDescriptorBuilder Create()
            => new RouteDescriptorBuilder();

        public RouteDescriptorBuilder WithRouteName(string value)
            => WithData(data => _routeName = data, value);

        public RouteDescriptorBuilder WithRouteDescription(string value)
            => WithData(data => _routeDescription = data, value);

        public RouteDescriptorBuilder WithRouteFlightPlanIndex(int value)
            => WithData(data => _routeFlightPlanIndex = data, value);

        public RouteDescriptorBuilder WithWaypointDescriptor(IWaypointDescriptor waypointDescriptor)
            => WithData(data => _waypoints.Add(data), waypointDescriptor);

        public RouteDescriptorBuilder Clear()
            => WithData<object>(_ => _waypoints.Clear(), null);

        public override IRouteDescriptor Build()
            => new RouteDescriptor(_routeName, _routeDescription, _routeFlightPlanIndex, _waypoints);
    }
}