using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAclUser
{
    public int UserId { get; set; }

    public long ForumId { get; set; }

    public long AuthOptionId { get; set; }

    public long AuthRoleId { get; set; }

    public byte AuthSetting { get; set; }
}
