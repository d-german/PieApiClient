using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PieApiClient;

namespace PieClientDriver
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var pies = GetPies().Result;
        }

        static async Task<IEnumerable<Pie>> GetPies()
        {

            return await PieClient.GetPiesAsync("http://localhost:58388/api/pies");

        } 
    }
}
