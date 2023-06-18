namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IWaypointDescriptor
    {
        string Identifier { get; }

        decimal Latitude { get; }

        decimal Longitude { get; }

        decimal Elevation { get; }

        string CountryCode { get; }

        string WaypointType { get; }

        string Description { get; }
    }
}