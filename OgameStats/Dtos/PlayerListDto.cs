using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    [XmlRoot("players")]
    public class PlayersListDto
    {

        [XmlElement("player")]
        public List<PlayerDto> player { get; set; }
    }
}
