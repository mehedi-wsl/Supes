using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Superscrapbook.Application.Repositories;
using Supescrapbook.Infrastructure.Repositories;

namespace SupesScrapbook.Infrastructure;

public static class DepedencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceProvider, IConfiguration configuration)
    {
        var mongoDbSettings = configuration.GetSection("MongoDbSettings");
        var mongoClient = new MongoClient(mongoDbSettings["ConnectionString"]);
        var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings["DatabaseName"]);

        serviceProvider.AddSingleton(mongoDatabase);
        serviceProvider.AddScoped<ISupeRepository, SupeRepository>();
        return serviceProvider;
    }
}