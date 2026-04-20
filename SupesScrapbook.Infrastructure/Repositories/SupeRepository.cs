using MongoDB.Driver;
using Superscrapbook.Application.Repositories;
using SupesScrapbook.Domain.Entities;
using SupesScrapbook.Infrastructure.Documents;
using SupesScrapbook.Infrastructure.Mapper;
namespace Supescrapbook.Infrastructure.Repositories;

public class SupeRepository : ISupeRepository
{
    private readonly IMongoCollection<SupeDocument> _supeCollection;

    public SupeRepository(IMongoDatabase mongoDatabase)
    {
        _supeCollection = mongoDatabase.GetCollection<SupeDocument>("SuperHero");
    }
    public async Task<Supe?> GetSupesById(int id)
    {
        var doc = await _supeCollection.Find(g => g.Id == id).FirstOrDefaultAsync();
        return doc?.ToDomain();
    }
}