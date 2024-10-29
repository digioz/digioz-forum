using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumBbcode
{
    public short BbcodeId { get; set; }

    public string BbcodeTag { get; set; } = null!;

    public string BbcodeHelpline { get; set; } = null!;

    public byte DisplayOnPosting { get; set; }

    public string BbcodeMatch { get; set; } = null!;

    public string BbcodeTpl { get; set; } = null!;

    public string FirstPassMatch { get; set; } = null!;

    public string FirstPassReplace { get; set; } = null!;

    public string SecondPassMatch { get; set; } = null!;

    public string SecondPassReplace { get; set; } = null!;
}
