﻿using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
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