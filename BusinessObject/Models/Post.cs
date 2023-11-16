using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string? PostTitle { get; set; }

    public string? PostContent { get; set; }
}
