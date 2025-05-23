﻿using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTopic
{
    public long TopicId { get; set; }

    public long ForumId { get; set; }

    public long IconId { get; set; }

    public byte TopicAttachment { get; set; }

    public byte TopicReported { get; set; }

    public string TopicTitle { get; set; } = null!;

    public int TopicPoster { get; set; }

    public DateTime? TopicTime { get; set; }

    public long TopicTimeLimit { get; set; }

    public long TopicViews { get; set; }

    public byte TopicStatus { get; set; }

    public byte TopicType { get; set; }

    public long TopicFirstPostId { get; set; }

    public string TopicFirstPosterName { get; set; } = null!;

    public string TopicFirstPosterColor { get; set; } = null!;

    public long TopicLastPostId { get; set; }

    public int TopicLastPosterId { get; set; }

    public string TopicLastPosterName { get; set; } = null!;

    public string TopicLastPosterColor { get; set; } = null!;

    public string TopicLastPostSubject { get; set; } = null!;

    public DateTime? TopicLastPostTime { get; set; }

    public DateTime? TopicLastViewTime { get; set; }

    public long TopicMovedId { get; set; }

    public byte TopicBumped { get; set; }

    public long TopicBumper { get; set; }

    public string PollTitle { get; set; } = null!;

    public DateTime? PollStart { get; set; }

    public int PollLength { get; set; }

    public byte PollMaxOptions { get; set; }

    public DateTime? PollLastVote { get; set; }

    public byte PollVoteChange { get; set; }

    public byte TopicVisibility { get; set; }

    public DateTime? TopicDeleteTime { get; set; }

    public string TopicDeleteReason { get; set; } = null!;

    public int TopicDeleteUser { get; set; }

    public long TopicPostsApproved { get; set; }

    public long TopicPostsUnapproved { get; set; }

    public long TopicPostsSoftdeleted { get; set; }
}
