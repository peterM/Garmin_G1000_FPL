using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;
using MalikP.Aviation.Garmin.G1000.FPL.Generators;
using MalikP.Aviation.Garmin.G1000.FPL.Models.Builders;
using MalikP.Aviation.Garmin.G1000.FPL.Repository;

namespace MalikP.Aviation.Garmin.G1000.FPL.Console
{
    public class Test_V1
    {
        public Test_V1()
        {
        }

        public string GetFpl_V1()
        {
            IWaypointDescriptor waypointDescriptorLzib = WaypointDescriptorBuilder.Create()
                .WithWaypointIdentifier("LZIB")
                .Build();

            IWaypointDescriptor waypointDescriptorNit = WaypointDescriptorBuilder.Create()
                .WithWaypointIdentifier("NIT")
                .Build();

            IWaypointDescriptor waypointDescriptorSlc = WaypointDescriptorBuilder.Create()
                .WithWaypointIdentifier("SLC")
                .Build();

            IWaypointDescriptor waypointDescriptorKsc = WaypointDescriptorBuilder.Create()
                .WithWaypointIdentifier("KSC")
                .Build();

            IWaypointDescriptor waypointDescriptorLzkz = WaypointDescriptorBuilder.Create()
                .WithWaypointIdentifier("LZKZ")
                .Build();

            IRouteDescriptor routeDescriptor = RouteDescriptorBuilder.Create()
                .WithRouteName("LZIB/LZKZ")
                .WithRouteDescription("BRATISLAVA to KOSICE")
                .WithRouteFlightPlanIndex(1)
                .WithWaypointDescriptor(waypointDescriptorLzib)
                .WithWaypointDescriptor(waypointDescriptorNit)
                .WithWaypointDescriptor(waypointDescriptorSlc)
                .WithWaypointDescriptor(waypointDescriptorKsc)
                .WithWaypointDescriptor(waypointDescriptorLzkz)
                .Build();

            IFlightPlanDescriptor flightPlanDescriptor = FlightPlanDescriptorBuilder.Create()
                .WithRouteDescriptor(routeDescriptor)
                .Build();

            IWaypointRepository_V1 waypointRepository = new WaypointRepository_V1();
            IFlightPlanGenerator fplGenerator = new FlightPlanGenerator_V1(waypointRepository, new RouteGenerator_V1(waypointRepository));
            return fplGenerator?.GetFlightPlan(flightPlanDescriptor)
                ?.AsXml(new FlightPlanSerializer());
        }
    }
}