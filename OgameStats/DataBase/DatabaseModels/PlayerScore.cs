using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase.DatabaseModels
{
    public class PlayerScore
    {
        public int ID { get; set; }
        public int TotalScore { get; set; }
        public int ResearchStore { get; set; }
        public int MilitaryScore { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
