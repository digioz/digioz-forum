﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace digioz.Forum.Models;

public partial class ForumSession
{
    [Key]
    public string SessionId { get; set; } = null!;

    public int SessionUserId { get; set; }

    public DateTime? SessionLastVisit { get; set; }

    public DateTime? SessionStart { get; set; }

    public DateTime? SessionTime { get; set; }

    public string SessionIp { get; set; } = null!;

    public string SessionBrowser { get; set; } = null!;

    public string SessionForwardedFor { get; set; } = null!;

    public string SessionPage { get; set; } = null!;

    public byte SessionViewOnline { get; set; }

    public byte SessionAutoLogin { get; set; }

    public byte SessionAdmin { get; set; }

    public long SessionForumId { get; set; }
}
