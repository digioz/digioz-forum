using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumUserGroup
{
    public long GroupId { get; set; }

    public int UserId { get; set; }

    public byte GroupLeader { get; set; }

    public byte UserPending { get; set; }
}
