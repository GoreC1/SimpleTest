using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SimpleTest.Repositories
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task<bool?> Remove(T entity);
        Task<bool?> RemoveRange(IEnumerable<T> entities);
    }
}
