using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase.DatabaseModels
{
    public class Alliance
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public string founder { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
