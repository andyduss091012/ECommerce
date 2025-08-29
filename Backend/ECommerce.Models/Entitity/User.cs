using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models;

public class User : BaseEntity
{
	#region [ CTor ]
	public User() : base(){

	}
	#endregion

	#region [ Properties ]
	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public string? Email { get; set; }

	public string? Password { get; set; }

	public string? Phone { get; set; }

    public bool? Verified { get; set; }

	//public string? Role { get; set; }

	//public string? RoleId { get; set; }

	public ICollection<Address>? Addresses { get; set; } = new List<Address>();


    #endregion
}
