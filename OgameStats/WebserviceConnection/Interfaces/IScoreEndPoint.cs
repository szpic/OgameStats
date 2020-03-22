using OgameStats.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgameStats.WebserviceConnection.Interfaces
{
    public interface IScoreEndPoint : IAsyncFunction<string, Highscore>
    {
    }
}
