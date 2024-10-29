using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumConfirm
{
    public string ConfirmId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public byte ConfirmType { get; set; }

    public string Code { get; set; } = null!;

    public int Seed { get; set; }

    public long Attempts { get; set; }
}
