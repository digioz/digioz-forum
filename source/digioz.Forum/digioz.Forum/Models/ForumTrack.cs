using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTrack
{
    public int UserId { get; set; }

    public long ForumId { get; set; }

    public int MarkTime { get; set; }
}
