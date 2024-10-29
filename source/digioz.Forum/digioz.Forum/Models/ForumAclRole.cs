using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAclRole
{
    public long RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string RoleDescription { get; set; } = null!;

    public string RoleType { get; set; } = null!;

    public short RoleOrder { get; set; }
}
