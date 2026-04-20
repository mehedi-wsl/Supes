using SupesScrapbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supescrapbook.Application.Services
{
    public interface ISupeService
    {
        Task<Supe?> GetSupeById(int id);

    }
}
