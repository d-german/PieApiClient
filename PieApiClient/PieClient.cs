using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PieApiClient
{ // PM> Install-Package Microsoft.AspNet.WebApi.Client 
    public class PieClient
    {
        private static readonly HttpClient Client = new HttpClient();

        public PieClient()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<IEnumerable<Pie>> GetPiesAsync(string path)
        {
            IEnumerable<Pie> pies = null;
            var response = await Client.GetAsync(path);
            if (response.IsSuccessStatusCode) pies = await response.Content.ReadAsAsync<IEnumerable<Pie>>();
            return pies;
        }
    }
}