namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IWaypointDescriptor
    {
        string Identifier { get; }

        string CountryCode { get; }
    }
}