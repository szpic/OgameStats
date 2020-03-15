using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    public class PlayerDto
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("alliance")]
        public string alliance { get; set; }
        [XmlAttribute("status")]
        public string status { get; set; }
    }
}
