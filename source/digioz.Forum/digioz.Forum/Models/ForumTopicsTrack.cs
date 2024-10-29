using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTopicsTrack
{
    public int UserId { get; set; }

    public int TopicId { get; set; }

    public long ForumId { get; set; }

    public int MarkTime { get; set; }
}
