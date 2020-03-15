using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OgameStats.WebserviceConnection.Base
{
    public class ApiClient : IApiClient
    {
        static Lazy<HttpClient> client = new Lazy<HttpClient>(() =>
        {
            var client = new HttpClient();
            return client;
        });

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            return client.Value.GetAsync(url);
        }
    }
}
