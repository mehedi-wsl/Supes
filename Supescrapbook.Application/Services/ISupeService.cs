using SupesScrapbook.Infrastructure.Documents;

namespace SupesScrapbook.Application.Services
{
    public interface ISupeService
    {
        Task<SupeDocument> GetSupeById(int id);

    }
}
