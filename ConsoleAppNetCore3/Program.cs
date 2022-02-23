using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ConsoleAppNetCore3
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .UseConsoleLifetime()
                .ConfigureHostConfiguration(builder => { })
                .ConfigureAppConfiguration((hostContext, builder) => { })
                .ConfigureLogging((hostContext, builder) => { })
                .ConfigureServices((hostContext, builder) => { });

            using var host = hostBuilder.Build();

            await host.RunAsync();

            return 0;
        }
    }
}
