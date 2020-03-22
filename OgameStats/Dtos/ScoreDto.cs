using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    [XmlRoot("player")]
    public class ScoreDto
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlAttribute("position")]
        public string position { get; set; }
        [XmlAttribute("score")]
        public string score { get; set; }
    }
}
