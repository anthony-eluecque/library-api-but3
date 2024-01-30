using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Data;
using DataAccessLayer.Repository;
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
        catalogService.GetBetterGradeBook();

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        var connectionString = configuration.Build().GetConnectionString("DefaultConnection");

        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddScoped<ICatalogService, CatalogService>();
                services.AddScoped<ICatalogManager, CatalogManager>();
                services.AddScoped<IRepository<Book>, BookRepository>();
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(connectionString);
                });
            });
    }
}
