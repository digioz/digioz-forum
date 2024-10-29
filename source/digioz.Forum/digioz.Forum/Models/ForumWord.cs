using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumWord
{
    public int WordId { get; set; }

    public string Word { get; set; } = null!;

    public string Replacement { get; set; } = null!;
}
