﻿using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder();

        var host = CreateHostBuilder(configuration).Build();
        var catalogService = host.Services.GetRequiredService<ICatalogService>();
        catalogService.ShowCatalog();
        catalogService.FindBook(1);
        catalogService.GetFantasyBooks();
        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<ICatalogService, CatalogService>();
            });
    }
}
