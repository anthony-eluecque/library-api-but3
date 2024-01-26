using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var host = CreateHostBuilder(configuration).Build();
        var catalogService = host.Services.GetRequiredService<ICatalogService>();
        catalogService.ShowCatalog();
        catalogService.FindBook(3);
        catalogService.GetFantasyBooks();
        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        var connectionString = configuration.Build().GetConnectionString("DefaultConnection");

        Console.WriteLine("Connection String");
        Console.WriteLine(connectionString);

        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<ICatalogService, CatalogService>();
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(connectionString);
                });
            });
    }
}
