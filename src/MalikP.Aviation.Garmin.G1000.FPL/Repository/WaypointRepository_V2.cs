using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.V2;

namespace MalikP.Aviation.Garmin.G1000.FPL.Repository
{
    public sealed class WaypointRepository_V2 : IWaypointRepository_V2
    {
        public IWaypoint GetWaypoint(IWaypointDescriptor waypointDescriptor)
        {
            // Connect to database
            return new WaypointType
            {
                CountryCode = waypointDescriptor.CountryCode,
                Identifier = waypointDescriptor.Identifier,
            };
        }
    }
}