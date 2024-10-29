using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPollOption
{
    public byte PollOptionId { get; set; }

    public int TopicId { get; set; }

    public string PollOptionText { get; set; } = null!;

    public long PollOptionTotal { get; set; }
}
