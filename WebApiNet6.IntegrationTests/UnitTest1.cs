using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace WebApiNet6.IntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            using WebApplicationFactory<Program> factory = new();

            using var client = factory.CreateDefaultClient();

            using HttpRequestMessage httpRequestMessage = new(HttpMethod.Get, new Uri("/swagger/index.html", UriKind.Relative));

            using var httpResponseMessage = await client.SendAsync(httpRequestMessage);

            Assert.AreEqual(HttpStatusCode.OK, httpResponseMessage.StatusCode);
        }
    }
}
