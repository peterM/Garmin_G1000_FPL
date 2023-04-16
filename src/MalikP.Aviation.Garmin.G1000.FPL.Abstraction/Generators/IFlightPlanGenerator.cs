using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators
{
    public interface IFlightPlanGenerator
    {
        IFlightPlan GetRoute(IFlightPlanDescriptor flightPlanDescriptor);
    }
}
