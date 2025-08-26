namespace ECommerce.Models;

public class Category
{
    #region [ CTor ]
    public Category() {
        Id = Guid.NewGuid().ToString();
        Products = new List<Product>();
    }
    #endregion

    #region [ Properties ]
    public string Id { get; set; }

    public string? Name { get; set; }

    public ICollection<Product>? Products { get; set; }
    #endregion
}
