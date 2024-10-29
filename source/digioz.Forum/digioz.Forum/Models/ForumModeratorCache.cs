using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumModeratorCache
{
    public long ForumId { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public long GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public byte DisplayOnIndex { get; set; }
}
