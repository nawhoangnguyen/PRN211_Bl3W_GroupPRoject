using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ShoppingSessionDTO
{
    public int ShoppingId { get; set; }

    public int? MemberId { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<CartItemDTO> CartItems { get; set; } = new List<CartItemDTO>();

    public virtual MemberDTO? Member { get; set; }
}
