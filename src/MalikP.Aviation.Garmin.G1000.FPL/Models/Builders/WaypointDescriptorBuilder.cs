using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models.Builders
{
    public sealed class WaypointDescriptorBuilder : AbstractBuilder<WaypointDescriptorBuilder, IWaypointDescriptor>
    {
        private string _waypointType = V1.WaypointTypeEnum.USER_WAYPOINT.ToString();

        private string _waypointCountryCode;
        private string _waypointIdentifier;

        private decimal _waypointLatitude;
        private decimal _waypointLongitude;
        private decimal _waypointElevation = -1;

        private string _waypointDescription = string.Empty;

        private WaypointDescriptorBuilder()
            : base()
        {
        }

        public static WaypointDescriptorBuilder Create()
            => new WaypointDescriptorBuilder();

        public WaypointDescriptorBuilder WithWaypointType(V1.WaypointTypeEnum value)
            => WithData(data => _waypointType = data.ToString(), value);

        public WaypointDescriptorBuilder WithWaypointType(V2.WaypointTypeEnum value)
            => WithData(data => _waypointType = data.ToString(), value);

        public WaypointDescriptorBuilder WithWaypointCountryCode(string value)
            => WithData(data => _waypointCountryCode = data, value);

        public WaypointDescriptorBuilder WithWaypointIdentifier(string value)
            => WithData(data => _waypointIdentifier = data, value);

        public WaypointDescriptorBuilder WithWaypointLatitude(decimal value)
            => WithData(data => _waypointLatitude = data, value);

        public WaypointDescriptorBuilder WithWaypointLongitude(decimal value)
            => WithData(data => _waypointLongitude = data, value);

        public WaypointDescriptorBuilder WithWaypointElevation(decimal value)
            => WithData(data => _waypointElevation = data, value);

        public WaypointDescriptorBuilder WithWaypointDescription(string value)
            => WithData(data => _waypointDescription = data, value);

        public override IWaypointDescriptor Build()
            => new WaypointDescriptor(
                _waypointType,
                GetCountryCode(),
                _waypointIdentifier,
                _waypointLatitude,
                _waypointLongitude,
                _waypointElevation,
                _waypointDescription);

        private string GetCountryCode()
        {
            return string.Equals(_waypointType, V1.WaypointTypeEnum.USER_WAYPOINT)
                || string.Equals(_waypointType, V2.WaypointTypeEnum.USER_WAYPOINT)
                ? null
                : _waypointCountryCode;
        }
    }
}