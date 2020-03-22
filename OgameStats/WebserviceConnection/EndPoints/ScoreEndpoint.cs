using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgameStats.WebserviceConnection.Base;

namespace OgameStats.WebserviceConnection.EndPoints
{
    public class ScoreEndPoint :IScoreEndPoint
    {
        private readonly string baseUrl;
        private readonly string types;
        private readonly IApiClient client;

        public ScoreEndPoint(IApiClient client)
        {
            this.client = client;
            baseUrl = @"https://s117-pl.ogame.gameforge.com/api/highscore.xml";

        }

        public Task<Highscore> ExecuteAsync(string type)
        {
            return client.GetAsAsync<Highscore>(baseUrl + $"?category=1&type={type}");
        }
    }
}
