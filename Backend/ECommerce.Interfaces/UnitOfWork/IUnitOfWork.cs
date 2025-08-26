namespace ECommerce.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IProductDataProvider Products { get; }

    //ICategoryDataProvider Categories { get; }

    Task<int> SaveChangesAsync();
}
