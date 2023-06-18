using System;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Repository;
using MalikP.Aviation.Garmin.G1000.FPL.V1;

namespace MalikP.Aviation.Garmin.G1000.FPL.Repository
{
    public sealed class WaypointRepository_V1 : IWaypointRepository_V1
    {
        public IWaypoint GetWaypoint(IWaypointDescriptor waypointDescriptor)
        {
            WaypointTypeEnum wpType = (WaypointTypeEnum)Enum.Parse(typeof(WaypointTypeEnum), waypointDescriptor.WaypointType);

            // Connect to database
            return new WaypointType
            {
                CountryCode = wpType == WaypointTypeEnum.USER_WAYPOINT ? null : waypointDescriptor.CountryCode,
                Identifier = waypointDescriptor.Identifier,
                Latitude = waypointDescriptor.Latitude,
                Longitude = waypointDescriptor.Longitude,
                Elevation = waypointDescriptor.Elevation,
                ElevationSpecified = waypointDescriptor.Elevation > -1,
                Type = wpType,
                Comment = waypointDescriptor.Description
            };
        }
    }
}