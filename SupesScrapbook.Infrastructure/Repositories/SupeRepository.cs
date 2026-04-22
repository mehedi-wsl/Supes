using MongoDB.Driver;
using SupesScrapbook.Infrastructure.Documents;
namespace SupesScrapbook.Infrastructure.Repositories;

public class SupeRepository : ISupeRepository
{
    private readonly IMongoCollection<SupeDocument> _supeCollection;

    public SupeRepository(IMongoDatabase mongoDatabase)
    {
        _supeCollection = mongoDatabase.GetCollection<SupeDocument>("SuperHero");
    }
    public async Task<SupeDocument> GetSupesById(int id)
    {
        return await _supeCollection.Find(g => g.Id == id).FirstOrDefaultAsync();
    }
}