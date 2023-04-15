using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    public partial class EmailType
    {
        [XmlAttribute(AttributeName = "id")]
        public string ID { get; set; }

        [XmlAttribute(AttributeName = "domain")]
        public string Domain { get; set; }
    }
}