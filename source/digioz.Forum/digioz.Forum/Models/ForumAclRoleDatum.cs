using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAclRoleDatum
{
    public long RoleId { get; set; }

    public long AuthOptionId { get; set; }

    public byte AuthSetting { get; set; }
}
