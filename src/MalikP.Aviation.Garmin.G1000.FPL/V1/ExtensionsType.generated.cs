using System.Xml;
using System.Xml.Serialization;

namespace MalikP.Aviation.Garmin.G1000.FPL.V1
{
    public partial class ExtensionsType
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
}