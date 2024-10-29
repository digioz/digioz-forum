using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumReport
{
    public int ReportId { get; set; }

    public short ReasonId { get; set; }

    public int PostId { get; set; }

    public int UserId { get; set; }

    public byte UserNotify { get; set; }

    public byte ReportClosed { get; set; }

    public int ReportTime { get; set; }

    public string ReportText { get; set; } = null!;

    public int PmId { get; set; }

    public byte ReportedPostEnableBbcode { get; set; }

    public byte ReportedPostEnableSmilies { get; set; }

    public byte ReportedPostEnableMagicUrl { get; set; }

    public string ReportedPostText { get; set; } = null!;

    public string ReportedPostUid { get; set; } = null!;

    public string ReportedPostBitfield { get; set; } = null!;
}
