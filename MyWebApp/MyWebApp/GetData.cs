using System.Net.Http;

namespace MyWebApp
{
    public class GetData
    {
        public object Get()
        {
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Add("Api-Key", "app-key");
            var result = httpclient.GetAsync("https://trams-external-api.azurewebsites.net/establishment/urn/139318");
            return result;
        }
    }
}