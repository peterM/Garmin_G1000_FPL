using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models
{
    public sealed class WaypointDescriptor : IWaypointDescriptor
    {
        public WaypointDescriptor(
            string countryCode,
            string identifier)
        {
            CountryCode = countryCode;
            Identifier = identifier;
        }

        public string Identifier { get; }

        public string CountryCode { get; }
    }
}