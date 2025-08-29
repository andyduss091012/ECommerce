namespace ECommerce.Models;

public class CartItem : BaseEntity
{
    #region [ CTor ]
    public CartItem() : base() {

    }
    #endregion

    #region [ Properties ]
    public int Quantity { get; set; }

    public string ProductId { get; set; }

    public Product? Product { get; set; }

    public string UserId { get; set; }

    public User? User { get; set; }
    #endregion
}
