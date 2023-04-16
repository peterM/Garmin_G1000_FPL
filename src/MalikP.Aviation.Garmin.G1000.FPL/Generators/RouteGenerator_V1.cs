﻿using System.Linq;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.V1;

namespace MalikP.Aviation.Garmin.G1000.FPL.Generators
{
    public class RouteGenerator_V1 : IRouteGenerator_V1
    {
        private readonly IWaypointRepository _waypointRepository;

        public RouteGenerator_V1(IWaypointRepository_V1 waypointRepository)
        {
            _waypointRepository = waypointRepository;
        }

        public IRoute GetRoute(IRouteDescriptor routeDescriptor)
        {
            IRoute route = new RouteType
            {
                FlightPlanIndex = routeDescriptor.FlightPlanIndex.ToString(),
                RouteName = routeDescriptor.RouteName,
                RouteDescription = routeDescriptor.RouteDescription
            };

            foreach (var routePoint in routeDescriptor.Waypoints.OrderBy(d => d.Key))
            {
                var point = _waypointRepository.GetWaypoint(routePoint.Value);
                point?.AddToRoute(route);
            }

            return route;
        }
    }
}