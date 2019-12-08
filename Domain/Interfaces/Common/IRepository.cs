using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces.Common
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T item);
        Task<T> GetByIdAsync(int Id);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        IAsyncEnumerable<T> GetAllAsync();
        Task RemoveAsync(T item);
        Task<bool> UpdateAsync(T item);

    }
}
