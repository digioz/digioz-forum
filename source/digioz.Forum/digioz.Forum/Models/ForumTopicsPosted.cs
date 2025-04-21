using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTopicsPosted
{
    public int UserId { get; set; }

    public long TopicId { get; set; }

    public byte TopicPosted { get; set; }
}
