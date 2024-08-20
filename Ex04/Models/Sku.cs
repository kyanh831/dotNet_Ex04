using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class Sku
{
    public int SkuId { get; set; }

    public int? ProductId { get; set; }

    public string Sku1 { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }

    public bool? IsActive { get; set; }
}
