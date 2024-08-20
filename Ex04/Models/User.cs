using System;
using System.Collections.Generic;

namespace Ex04.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModified { get; set; }
}
