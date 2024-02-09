using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Data;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;
using System.Configuration;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        ConfigureServices(builder.Services);

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }


    private static void ConfigureServices(IServiceCollection services)
    {

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<ICatalogManager, CatalogManager>();
        services.AddScoped<IRepository<Book>, BookRepository>();
    }
}