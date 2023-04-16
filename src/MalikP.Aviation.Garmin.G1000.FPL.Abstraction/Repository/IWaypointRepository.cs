using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository
{
    public interface IWaypointRepository
    {
        IWaypoint GetWaypoint(IWaypointDescriptor waypointDescriptor);
    }
}
