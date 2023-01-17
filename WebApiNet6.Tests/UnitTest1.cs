using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using WebApiNet6.Controllers;

namespace WebApiNet6.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ILogger<WeatherForecastController> logger = new NullLogger<WeatherForecastController>();

        [TestMethod]
        public void TestMethod1()
        {
            _ = new WeatherForecastController(logger);
        }
    }
}
