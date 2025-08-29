namespace ECommerce.Models;

public class BaseEntity
{
    #region [ CTor ]
    public BaseEntity() {
        Id = Guid.NewGuid().ToString();
        IsActive = true;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    #endregion

    public string Id { get; set; } 

    public bool IsActive { get; set; } 

    public DateTime CreatedAt { get; set; } 

    public DateTime UpdatedAt { get; set; }
}
