using OgameStats.Dtos;
using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgameStats.WebserviceConnection.Base;

namespace OgameStats.WebserviceConnection.EndPoints
{
    public class AlliancesEndPoint :IAlliancesEndPoint
    {
        private readonly string baseUrl;
        private readonly IApiClient client;

        public AlliancesEndPoint(IApiClient client)
        {
            this.client = client;
            baseUrl = @"https://s117-pl.ogame.gameforge.com/api/alliances.xml";
        }

        public Task<AlliancesListDto> ExecuteAsync()
        {
            return client.GetAsAsync<AlliancesListDto>(baseUrl);
        }
    }
}
