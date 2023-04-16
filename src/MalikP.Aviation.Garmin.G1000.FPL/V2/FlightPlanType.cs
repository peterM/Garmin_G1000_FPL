using System;
using System.Xml.Serialization;

using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;
using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot("flight-plan", Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd", IsNullable = false)]
    public partial class FlightPlanType : IFlightPlan
    {
        public string AsXml(IFlightPlanSerializer flightPlanSerializer)
            => flightPlanSerializer?.SerializeToXml<FlightPlanType>(this);
    }
}