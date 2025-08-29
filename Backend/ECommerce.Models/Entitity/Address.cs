namespace ECommerce.Models;

public class Address : BaseEntity
{
    #region [ CTor ]
    public Address() : base() {

    }
    #endregion

    #region [ Properties ]
    public string? Street { get; set; }
    
    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string UserId { get; set; }

    public User? User { get; set; }
    #endregion
}
