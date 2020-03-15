using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    [XmlRoot("alliances")]
    public class AlliancesListDto
    {

        [XmlElement("alliance")]
        public List<AllianceDto> alliance { get; set; }
    }
}
