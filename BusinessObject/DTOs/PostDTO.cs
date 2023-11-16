using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PostDTO
{
    public int PostId { get; set; }

    public string? PostTitle { get; set; }

    public string? PostContent { get; set; }
}
