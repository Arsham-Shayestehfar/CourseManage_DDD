using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(BaseId id);
        Task CreateAsync (T entity);
        Task UpdateAsync (T entity);
        Task DeleteAsync (T entity);

    }
}
