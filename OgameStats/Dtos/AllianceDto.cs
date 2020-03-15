using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    public class AllianceDto
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("tag")]
        public string tag { get; set; }
        [XmlAttribute("founder")]
        public string founder { get; set; }
    }
}
