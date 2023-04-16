using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;
using MalikP.Core.Serialization.Xml;

namespace MalikP.Aviation.Garmin.G1000.FPL.Console
{
    public sealed class FlightPlanSerializer : IFlightPlanSerializer
    {
        public string SerializeToXml<T>(T data)
            => data.SerializeToXml<T>();
    }
}