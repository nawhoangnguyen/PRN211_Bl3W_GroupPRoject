using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ShoppingSession
{
    public int ShoppingId { get; set; }

    public int? MemberId { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Member? Member { get; set; }
}
