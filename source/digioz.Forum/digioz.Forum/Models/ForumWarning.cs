using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumWarning
{
    public long WarningId { get; set; }

    public int UserId { get; set; }

    public long PostId { get; set; }

    public int LogId { get; set; }

    public DateTime? WarningTime { get; set; }
}
