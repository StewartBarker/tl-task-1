using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWebApp.DataServices
{
    public class GetData
    {
        public async Task<HttpResponseMessage> Get()
        {
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Add("ApiKey", "app-key");
            var response = await httpclient.GetAsync("https://trams-external-api.azurewebsites.net/establishment/urn/139318");
            return response;
        }
    }
}