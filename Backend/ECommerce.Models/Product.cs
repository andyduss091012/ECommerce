namespace ECommerce.Models;

public class Product
{
    #region [ CTor ]
    public Product() {
        Id = Guid.NewGuid().ToString();
        CreatedAt = DateTime.UtcNow;
        IsActive = true;
    }
    #endregion

    #region [ Properties ]
    public string Id { get; set; }

    public bool IsActive { get; set; }

    public string? Name { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CategoryId { get; set; }

    public Category? Category { get; set; }
    #endregion
}
