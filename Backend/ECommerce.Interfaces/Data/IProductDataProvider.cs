using ECommerce.Models;

namespace ECommerce.Interfaces;

public interface IProductDataProvider : IBaseDataProvider<Product>
{
    Task<IEnumerable<Product>> GetProductsByCategoryAsync(string categoryId);

    Task<IEnumerable<Product>> GetProductsByCategoryAsync(string[] categoryId);
}
