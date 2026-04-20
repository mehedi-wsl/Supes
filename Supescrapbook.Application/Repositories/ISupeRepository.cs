using SupesScrapbook.Domain.Entities;

namespace SupesScrapbook.Application.Repositories;

public interface ISupeRepository

{
    Task<Supe?> GetSupesById(int id);    
}