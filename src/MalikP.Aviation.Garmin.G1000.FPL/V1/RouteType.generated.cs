﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    public partial class RouteType
    {
        [XmlElement("route-name")]
        public string RouteName { get; set; }

        [XmlElement("route-description")]
        public string RouteDescription { get; set; }

        [XmlElement("flight-plan-index", DataType = "nonNegativeInteger")]
        public string FlightPlanIndex { get; set; }

        [XmlElement("route-point")]
        public List<RoutePointType> RoutePoints { get; set; } = new List<RoutePointType>();

        [XmlElement("extensions")]
        public ExtensionsType Extensions { get; set; }
    }
}