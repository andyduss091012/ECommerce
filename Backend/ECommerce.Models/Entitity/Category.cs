namespace ECommerce.Models;

public class Category : BaseEntity
{
    #region [ CTor ]
    public Category() : base() {
        Products = new List<Product>();
    }
    #endregion

    #region [ Properties ]
    public string? Name { get; set; }

    public ICollection<Product>? Products { get; set; }
    #endregion
}
