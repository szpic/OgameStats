using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    [XmlRoot("highscore")]
    public class Highscore
    {
            [XmlElement("player")]
            public List<ScoreDto> PlayerScore { get; set; }
    }
}
