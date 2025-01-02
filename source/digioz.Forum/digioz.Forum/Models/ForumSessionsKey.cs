using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSessionsKey
{
    public string KeyId { get; set; } = null!;

    public int UserId { get; set; }

    public string LastIp { get; set; } = null!;

    public long LastLogin { get; set; }
}
