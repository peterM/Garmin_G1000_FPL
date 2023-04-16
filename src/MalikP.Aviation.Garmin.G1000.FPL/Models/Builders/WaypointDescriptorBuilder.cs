using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Models.Builders
{
    public sealed class WaypointDescriptorBuilder : AbstractBuilder<WaypointDescriptorBuilder, IWaypointDescriptor>
    {
        private string _waypointCountryCode;
        private string _waypointIdentifier;

        private WaypointDescriptorBuilder()
            : base()
        {
        }

        public static WaypointDescriptorBuilder Create()
            => new WaypointDescriptorBuilder();

        public WaypointDescriptorBuilder With_waypointCountryCode(string value)
            => WithData(data => _waypointCountryCode = data, value);

        public WaypointDescriptorBuilder WithWaypointIdentifier(string value)
            => WithData(data => _waypointIdentifier = data, value);

        public override IWaypointDescriptor Build()
            => new WaypointDescriptor(_waypointCountryCode, _waypointIdentifier);
    }
}