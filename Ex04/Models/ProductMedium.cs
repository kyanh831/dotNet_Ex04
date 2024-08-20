using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class ProductMedium
{
    public int MediaId { get; set; }

    public int? SkuId { get; set; }

    public string? MediaType { get; set; }

    public string MediaUrl { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }
}
