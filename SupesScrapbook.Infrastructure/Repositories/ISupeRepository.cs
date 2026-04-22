using SupesScrapbook.Infrastructure.Documents;
namespace SupesScrapbook.Infrastructure.Repositories;

public interface ISupeRepository
{
    Task<SupeDocument> GetSupesById(int id);
}
