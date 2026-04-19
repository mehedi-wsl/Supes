namespace SupesScrapbook.Infrastructure.Extension;

public static class MongoDbExtension
{
    public static void ConfigureMongoDb(this IServiceProvider serviceProvider)
    {
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        var mongoDbSettings = configuration.GetSection("MongoDbSettings");
        var connectionString = mongoDbSettings["ConnectionString"];
        var dbName = mongoDbSettings["DatabaseName"];
    }
}