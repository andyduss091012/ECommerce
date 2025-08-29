using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models;

public class Order : BaseEntity
{
    #region [ CTor ]
    public Order() : base() {

    }
    #endregion

    #region [ Properties ]
    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public OrderStatus Status { get; set; }

    public string UserId { get; set; }

    public User? User { get; set; }

    public ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();

    public string? ShippingAddressId { get; set; }
    #endregion
}
