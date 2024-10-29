using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSmilie
{
    public long SmileyId { get; set; }

    public string Code { get; set; } = null!;

    public string Emotion { get; set; } = null!;

    public string SmileyUrl { get; set; } = null!;

    public short SmileyWidth { get; set; }

    public short SmileyHeight { get; set; }

    public long SmileyOrder { get; set; }

    public byte DisplayOnPosting { get; set; }
}
