using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OgameStats.WebserviceConnection.Interfaces
{
    public interface IApiClient
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}
