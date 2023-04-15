using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V2
{
    public partial class ExtensionsType
    {
        [XmlAnyElement]
        public List<XmlElement> Any { get; set; } = new List<XmlElement>();
    }
}