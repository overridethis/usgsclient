using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace UsgsClient.Common
{
    public class SimpleHttp : ISimpleHttp
    {
        private static readonly IDictionary<string, string> EmptyDictionary = new Dictionary<string, string>();

        public async Task<TResponseType> GetAsync<TResponseType>(
            Uri uri, 
            Dictionary<string, string> headers = null) 
        {
            var content = string.Empty;
            using (var client = new HttpClient())
            {
                var req = new HttpRequestMessage()
                {
                    Method = HttpMethod.Get,
                    RequestUri = uri
                };

                foreach (var header in headers ?? EmptyDictionary)
                    req.Headers.Add(header.Key, header.Value);

                var rsp = await client.SendAsync(req);

                // TODO: Error Handling.
                content = await rsp.Content.ReadAsStringAsync();
            }   
            return JsonConvert.DeserializeObject<TResponseType>(content);
        }
    }

}
