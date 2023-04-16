using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IFlightPlan
    {
        public string AsXml(IFlightPlanSerializer flightPlanSerializer);
    }
}