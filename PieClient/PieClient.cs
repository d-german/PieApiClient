using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PieClient
{
    public class PieClient
    {

        static HttpClient client = new HttpClient();
        static async Task<IEnumerable<Pie>> GetProductAsync(string path)
        {
            IEnumerable<Pie> pies = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                pies = await response.Content.ReadAsAsync<IEnumerable<Pie>>();
            }
            return pies;
        }
    }
}
