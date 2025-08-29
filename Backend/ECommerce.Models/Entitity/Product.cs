namespace ECommerce.Models;

public class Product : BaseEntity
{
    #region [ CTor ]
    public Product() : base() {
    }
    #endregion

    #region [ Properties ]

    public string? Name { get; set; }

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public int StockQuantity { get; set; }

    public string? CategoryId { get; set; }

    public Category? Category { get; set; }

    public string? ImageUrl { get; set; }

    public ICollection<OrderItem>? OrderItems { get; set; }

    public ICollection<CartItem> CartItems { get; set; }
    #endregion
}
