using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAccess
{
    public long ForumId { get; set; }

    public int UserId { get; set; }

    public string SessionId { get; set; } = null!;
}
