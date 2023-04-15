using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    [Serializable]
    [XmlType(Namespace = "http://www8.garmin.com/xmlschemas/FlightPlanv2.xsd")]
    [XmlRoot(ElementName = "author")]
    public partial class PersonType
    {
        [XmlElement("author-name")]
        public string AuthorName { get; set; }

        [XmlElement("email")]
        public EmailType Email { get; set; }

        [XmlElement(DataType = "anyURI", ElementName = "link")]
        public string Link { get; set; }
    }
}