using Newtonsoft.Json;
using OgameStats.WebserviceConnection.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OgameStats.WebserviceConnection.Base
{
    public static class ApiClientExtensions
    {
        public static async Task<TResult> GetAsAsync<TResult>(this IApiClient client, string url)
        {
            var data = await client.GetStringAsync(url);
            return DeserializeXml<TResult>(data);
            
        }

        public static async Task<string> GetStringAsync(this IApiClient client, string url)
        {
            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                return await ReadContentAsStringAsync(response).ConfigureAwait(false);
            }
        }

        private static async Task<string> ReadContentAsStringAsync(HttpResponseMessage response)
        {
            using (var content = response.Content)
            {
                return await content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        static TResult DeserializeXml<TResult>(string sourceXML) 
        {
            var serializer = new XmlSerializer(typeof(TResult));
            TResult result = default(TResult);

            using (TextReader reader = new StringReader(sourceXML))
            {
                result = (TResult)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
