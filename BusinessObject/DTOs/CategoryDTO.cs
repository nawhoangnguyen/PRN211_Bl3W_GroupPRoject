using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class CategoryDTO
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<ProductDTO> Products { get; set; } = new List<ProductDTO>();
}
