using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot(ElementName = "email")]
    public partial class EmailType
    {
    }
}