using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumStyle
{
    public long StyleId { get; set; }

    public string StyleName { get; set; } = null!;

    public string StyleCopyright { get; set; } = null!;

    public byte StyleActive { get; set; }

    public string StylePath { get; set; } = null!;

    public string BbcodeBitField { get; set; } = null!;

    public int StyleParentId { get; set; }

    public string StyleParentTree { get; set; } = null!;
}
