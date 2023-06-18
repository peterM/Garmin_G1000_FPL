using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models
{
    public sealed class WaypointDescriptor : IWaypointDescriptor
    {
        public WaypointDescriptor(
            string waypointType,
            string countryCode,
            string identifier,
            decimal latitude,
            decimal longitude,
            decimal elevation,
            string waypointDescription)
        {
            WaypointType = waypointType;
            CountryCode = countryCode;
            Identifier = identifier;
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
            Description = waypointDescription;
        }

        public string WaypointType { get; }

        public string Identifier { get; }

        public decimal Latitude { get; }

        public decimal Longitude { get; }

        public decimal Elevation { get; }

        public string Description { get; }

        public string CountryCode { get; }
    }
}