using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlan/v1")]
    [XmlRoot(ElementName = "email")]
    public partial class EmailType
    {
        [XmlAttribute(AttributeName = "id")]
        public string ID { get; set; }

        [XmlAttribute(AttributeName = "domain")]
        public string Domain { get; set; }
    }
}