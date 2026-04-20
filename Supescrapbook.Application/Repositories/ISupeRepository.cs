using SupesScrapbook.Domain.Entities;

namespace Superscrapbook.Application.Repositories;

public interface ISupeRepository

{
    Task<Supe?> GetSupesById(int id);    
}