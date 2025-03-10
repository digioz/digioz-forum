using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumBanlist
{
    public int BanId { get; set; }

    public int BanUserId { get; set; }

    public string BanIp { get; set; } = null!;

    public string BanEmail { get; set; } = null!;

    public DateTime? BanStart { get; set; }

    public DateTime? BanEnd { get; set; }

    public byte BanExclude { get; set; }

    public string BanReason { get; set; } = null!;

    public string BanGiveReason { get; set; } = null!;
}
