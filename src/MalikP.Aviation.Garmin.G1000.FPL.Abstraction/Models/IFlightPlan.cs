using System.Collections.Generic;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IFlightPlan
    {
        void AddRoute(IRoute route);

        void AddWaypoints(IEnumerable<KeyValuePair<int, IWaypoint>> waypoints);

        public string AsXml(IFlightPlanSerializer flightPlanSerializer);
    }
}