using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumWatch
{
    public long ForumId { get; set; }

    public int UserId { get; set; }

    public byte NotifyStatus { get; set; }
}
