using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgameStats.WebserviceConnection.Base;

namespace OgameStats.WebserviceConnection.EndPoints
{
    public class UniverseEndPoint :IUniverseEndPoint
    {
        private readonly string baseUrl;
        private readonly IApiClient client;

        public UniverseEndPoint(IApiClient client)
        {
            this.client = client;
            baseUrl = @"https://s117-pl.ogame.gameforge.com/api/universe.xml";
        }

        public Task<UniverseDto> ExecuteAsync()
        {
            return client.GetAsAsync<UniverseDto>(baseUrl);
        }
    }
}
