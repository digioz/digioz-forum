using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTopic
{
    public int TopicId { get; set; }

    public long ForumId { get; set; }

    public long IconId { get; set; }

    public byte TopicAttachment { get; set; }

    public byte TopicReported { get; set; }

    public string TopicTitle { get; set; } = null!;

    public int TopicPoster { get; set; }

    public int TopicTime { get; set; }

    public int TopicTimeLimit { get; set; }

    public long TopicViews { get; set; }

    public byte TopicStatus { get; set; }

    public byte TopicType { get; set; }

    public int TopicFirstPostId { get; set; }

    public string TopicFirstPosterName { get; set; } = null!;

    public string TopicFirstPosterColor { get; set; } = null!;

    public int TopicLastPostId { get; set; }

    public int TopicLastPosterId { get; set; }

    public string TopicLastPosterName { get; set; } = null!;

    public string TopicLastPosterColor { get; set; } = null!;

    public string TopicLastPostSubject { get; set; } = null!;

    public int TopicLastPostTime { get; set; }

    public int TopicLastViewTime { get; set; }

    public int TopicMovedId { get; set; }

    public byte TopicBumped { get; set; }

    public long TopicBumper { get; set; }

    public string PollTitle { get; set; } = null!;

    public int PollStart { get; set; }

    public int PollLength { get; set; }

    public byte PollMaxOptions { get; set; }

    public int PollLastVote { get; set; }

    public byte PollVoteChange { get; set; }

    public byte TopicVisibility { get; set; }

    public int TopicDeleteTime { get; set; }

    public string TopicDeleteReason { get; set; } = null!;

    public int TopicDeleteUser { get; set; }

    public long TopicPostsApproved { get; set; }

    public long TopicPostsUnapproved { get; set; }

    public long TopicPostsSoftdeleted { get; set; }
}
