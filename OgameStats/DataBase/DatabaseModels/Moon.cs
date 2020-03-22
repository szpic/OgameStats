using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase.DatabaseModels
{
    public class Moon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
