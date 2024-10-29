using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumIcon
{
    public long IconsId { get; set; }

    public string IconsUrl { get; set; } = null!;

    public byte IconsWidth { get; set; }

    public byte IconsHeight { get; set; }

    public string IconsAlt { get; set; } = null!;

    public long IconsOrder { get; set; }

    public byte DisplayOnPosting { get; set; }
}
