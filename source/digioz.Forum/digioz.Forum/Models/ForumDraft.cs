using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumDraft
{
    public int DraftId { get; set; }

    public int UserId { get; set; }

    public int TopicId { get; set; }

    public long ForumId { get; set; }

    public int SaveTime { get; set; }

    public string DraftSubject { get; set; } = null!;

    public string DraftMessage { get; set; } = null!;
}
