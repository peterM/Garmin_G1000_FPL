using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    public partial class WaypointType
    {
        [XmlElement("identifier")]
        public string Identifier { get; set; }

        [XmlElement("type")]
        public WaypointTypeEnum Type { get; set; }

        [XmlElement("country-code")]
        public string CountryCode { get; set; }

        [XmlElement("lat")]
        public decimal Latitude { get; set; }

        [XmlElement("lon")]
        public decimal Longitude { get; set; }

        [XmlElement("comment")]
        public string Comment { get; set; }

        [XmlElement("elevation")]
        public decimal Elevation { get; set; }

        [XmlIgnore]
        public bool ElevationSpecified { get; set; }

        [XmlElement("waypoint-description")]
        public string WaypointDescription { get; set; }

        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("extensions")]
        public ExtensionsType Extensions { get; set; }
    }
}