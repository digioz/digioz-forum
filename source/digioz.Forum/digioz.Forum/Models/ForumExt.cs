using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumExt
{
    public string ExtName { get; set; } = null!;

    public byte ExtActive { get; set; }

    public string ExtState { get; set; } = null!;
}
