using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAclOption
{
    public long AuthOptionId { get; set; }

    public string AuthOption { get; set; } = null!;

    public byte IsGlobal { get; set; }

    public byte IsLocal { get; set; }

    public byte FounderOnly { get; set; }
}
