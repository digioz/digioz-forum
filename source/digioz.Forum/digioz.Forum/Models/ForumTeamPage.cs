using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumTeamPage
{
    public long TeamPageId { get; set; }

    public long GroupId { get; set; }

    public string TeamPageName { get; set; } = null!;

    public long TeamPagePosition { get; set; }

    public long TeamPageParent { get; set; }
}
