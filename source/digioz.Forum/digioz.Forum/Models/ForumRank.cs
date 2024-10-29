using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumRank
{
    public long RankId { get; set; }

    public string RankTitle { get; set; } = null!;

    public long RankMin { get; set; }

    public byte RankSpecial { get; set; }

    public string RankImage { get; set; } = null!;
}
