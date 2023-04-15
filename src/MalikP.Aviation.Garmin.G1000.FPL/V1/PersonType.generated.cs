using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    public partial class PersonType
    {
        [XmlElement("author-name")]
        public string AuthorName { get; set; }

        [XmlElement("email")]
        public EmailType Email { get; set; }

        [XmlElement(ElementName = "link", DataType = "anyURI")]
        public string Link { get; set; }
    }
}