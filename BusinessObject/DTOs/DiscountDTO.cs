using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class DiscountDTO
{
    public int DiscountId { get; set; }

    public string? DiscountName { get; set; }

    public string? Description { get; set; }

    public decimal? DiscountPercent { get; set; }

    public virtual ICollection<ProductDTO> Products { get; set; } = new List<ProductDTO>();
}
