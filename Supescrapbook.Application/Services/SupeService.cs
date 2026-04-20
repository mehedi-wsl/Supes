using SupeScrapbook.Application.Repositories;
using SupesScrapbook.Domain.Entities;

namespace Supescrapbook.Application.Services
{
    public class SupeService : ISupeService
    {
        private readonly ISupeRepository _supeRepository;
        public SupeService(ISupeRepository supeRepository)
        {
            _supeRepository = supeRepository;
        }
        public async Task<Supe?> GetSupeById(int id)
        {
            return await _supeRepository.GetSupesById(id);
        }
    }
}
