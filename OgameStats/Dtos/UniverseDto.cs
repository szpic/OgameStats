using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    [XmlRoot("universe")]
    public class UniverseDto
    {

        [XmlElement("planet")]
        public List<PlanetDto> planet { get; set; }
    }
}
