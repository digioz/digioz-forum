using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumBot
{
    public int BotId { get; set; }

    public byte BotActive { get; set; }

    public string BotName { get; set; } = null!;

    public int UserId { get; set; }

    public string BotAgent { get; set; } = null!;

    public string BotIp { get; set; } = null!;
}
