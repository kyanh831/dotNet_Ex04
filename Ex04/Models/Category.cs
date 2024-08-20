using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class Category
{
    public string CategoryId { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }

    public bool? IsActive { get; set; }
}
