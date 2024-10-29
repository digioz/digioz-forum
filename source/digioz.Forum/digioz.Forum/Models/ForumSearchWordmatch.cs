using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSearchWordmatch
{
    public int PostId { get; set; }

    public int WordId { get; set; }

    public byte TitleMatch { get; set; }
}
