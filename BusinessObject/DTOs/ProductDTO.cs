using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ProductDTO
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public int? DiscountId { get; set; }

    public virtual ICollection<CartItemDTO> CartItems { get; set; } = new List<CartItemDTO>();

    public virtual CategoryDTO Category { get; set; } = null!;

    public virtual DiscountDTO? Discount { get; set; }

    public virtual ICollection<OrderDetailDTO> OrderDetails { get; set; } = new List<OrderDetailDTO>();
}
