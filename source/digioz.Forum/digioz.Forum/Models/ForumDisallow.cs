using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumDisallow
{
    public long DisallowId { get; set; }

    public string DisallowUsername { get; set; } = null!;
}
