using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumGroup
{
    public long GroupId { get; set; }

    public byte GroupType { get; set; }

    public byte GroupFounderManage { get; set; }

    public byte GroupSkipAuth { get; set; }

    public string GroupName { get; set; } = null!;

    public string GroupDesc { get; set; } = null!;

    public string GroupDescBitfield { get; set; } = null!;

    public int GroupDescOptions { get; set; }

    public string GroupDescUid { get; set; } = null!;

    public byte GroupDisplay { get; set; }

    public string GroupAvatar { get; set; } = null!;

    public string GroupAvatarType { get; set; } = null!;

    public short GroupAvatarWidth { get; set; }

    public short GroupAvatarHeight { get; set; }

    public long GroupRank { get; set; }

    public string GroupColour { get; set; } = null!;

    public long GroupSigChars { get; set; }

    public byte GroupReceivePm { get; set; }

    public long GroupMessageLimit { get; set; }

    public long GroupLegend { get; set; }

    public long GroupMaxRecipients { get; set; }
}
