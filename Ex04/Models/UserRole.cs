using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }
}
