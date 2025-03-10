using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumLoginAttempt
{
    public string AttemptIp { get; set; } = null!;

    public string AttemptBrowser { get; set; } = null!;

    public string AttemptForwardedFor { get; set; } = null!;

    public DateTime? AttemptTime { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string UsernameClean { get; set; } = null!;
}
