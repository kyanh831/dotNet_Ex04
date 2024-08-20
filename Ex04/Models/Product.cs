using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? CategoryId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }
}
