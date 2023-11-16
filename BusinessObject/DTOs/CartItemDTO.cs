using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class CartItemDTO
{
    public int CartItemId { get; set; }

    public int? ShoppingSessionId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual ProductDTO? Product { get; set; }

    public virtual ShoppingSessionDTO? ShoppingSession { get; set; }
}
