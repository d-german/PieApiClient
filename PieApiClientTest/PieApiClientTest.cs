using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PieApiClient;

namespace PieApiClientTest
{
    [TestClass]
    public class PieApiClientTest
    {
        [TestMethod]
        public async Task TestGetPies()
        {
            var pies = await PieClient.GetPiesAsync("http://localhost:58388/api/pies");
            Assert.IsNotNull(pies);
        }
    }
}