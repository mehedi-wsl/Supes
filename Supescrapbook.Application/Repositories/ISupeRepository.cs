namespace Superscrapbook.Application.Repositories;
public interface ISupeRepository
{
    Task<Object> GetSupesById(int id);    
}