using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int? ShoppingSessionId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ShoppingSession? ShoppingSession { get; set; }
}
