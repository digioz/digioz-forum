using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPollVote
{
    public int TopicId { get; set; }

    public byte PollOptionId { get; set; }

    public int VoteUserId { get; set; }

    public string VoteUserIp { get; set; } = null!;
}
