using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.Dtos
{
    public class MoonDto
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("size")]
        public string size { get; set; }
    }
}
