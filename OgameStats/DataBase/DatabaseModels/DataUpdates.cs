using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.DataBase.DatabaseModels
{
    public class DataUpdates
    {
        public string TableName { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
