using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSearchWordlist
{
    public int WordId { get; set; }

    public string WordText { get; set; } = null!;

    public byte WordCommon { get; set; }

    public long WordCount { get; set; }
}
