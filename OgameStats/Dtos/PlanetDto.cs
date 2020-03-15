using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    public class PlanetDto
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("player")]
        public string player { get; set; }
        [XmlAttribute("coords")]
        public string coords { get; set; }
        [XmlElement("moon")]
        public MoonDto moon { get; set; }
    }
}
