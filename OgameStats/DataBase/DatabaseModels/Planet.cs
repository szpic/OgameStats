using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase.DatabaseModels
{
    public class Planet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Player { get; set; }
        public string Coords { get; set; }
        public int? Moon { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
