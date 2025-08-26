using System.Linq.Expressions;

namespace ECommerce.Interfaces;

public interface IBaseDataProvider<T> where T : class
{`
    Task<T?> GetByIdAsync(string id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    Task AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(string id);
}
