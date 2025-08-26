namespace ECommerce.Interfaces;

public interface IBaseLogicRepository<T> where T : class
{
    Task<T?> GetByIdAsync(string id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate);

    Task CreateAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(string id);
}
