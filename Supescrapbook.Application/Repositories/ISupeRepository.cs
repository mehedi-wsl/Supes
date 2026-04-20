using SupesScrapbook.Domain.Entities;

namespace SupeScrapbook.Application.Repositories;

public interface ISupeRepository

{
    Task<Supe?> GetSupesById(int id);    
}