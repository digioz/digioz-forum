using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumReportsReason
{
    public short ReasonId { get; set; }

    public string ReasonTitle { get; set; } = null!;

    public string ReasonDescription { get; set; } = null!;

    public short ReasonOrder { get; set; }
}
