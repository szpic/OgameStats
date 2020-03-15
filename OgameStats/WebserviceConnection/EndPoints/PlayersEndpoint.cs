using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgameStats.WebserviceConnection.Base;

namespace OgameStats.WebserviceConnection.EndPoints
{
    public class PlayersEndPoint :IPlayerEndPoint
    {
        private readonly string baseUrl;
        private readonly IApiClient client;

        public PlayersEndPoint(IApiClient client)
        {
            this.client = client;
            baseUrl = @"https://s117-pl.ogame.gameforge.com/api/players.xml";
        }

        public Task<PlayersListDto> ExecuteAsync()
        {
            return client.GetAsAsync<PlayersListDto>(baseUrl);
        }
    }
}
