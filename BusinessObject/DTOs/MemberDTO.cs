using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class MemberDTO
{
    public int MemberId { get; set; }

    public string Email { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

    public virtual ICollection<ShoppingSessionDTO> ShoppingSessions { get; set; } = new List<ShoppingSessionDTO>();
}
