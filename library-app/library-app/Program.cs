using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

public class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder();

        var host = CreateHostBuilder(configuration).Build();
        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {

            });
    }
}
