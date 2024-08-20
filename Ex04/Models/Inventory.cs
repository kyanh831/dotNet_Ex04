using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? SkuId { get; set; }

    public int Quantity { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? LastModified { get; set; }
}
