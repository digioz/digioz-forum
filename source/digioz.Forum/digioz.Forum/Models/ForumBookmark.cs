using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumBookmark
{
    public long TopicId { get; set; }

    public int UserId { get; set; }
}
