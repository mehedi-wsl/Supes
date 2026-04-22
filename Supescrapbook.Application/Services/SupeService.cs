using SupesScrapbook.Infrastructure.Documents;
using SupesScrapbook.Infrastructure.Repositories;

namespace SupesScrapbook.Application.Services
{
    public class SupeService : ISupeService
    {
        private readonly ISupeRepository _supeRepository;
        public SupeService(ISupeRepository supeRepository)
        {
            _supeRepository = supeRepository;
        }
        public async Task<SupeDocument> GetSupeById(int id)
        {
            return await _supeRepository.GetSupesById(id);
        }
    }
}
