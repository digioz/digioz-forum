using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPrivmsg
{
    public int MsgId { get; set; }

    public long RootLevel { get; set; }

    public int AuthorId { get; set; }

    public long IconId { get; set; }

    public string AuthorIp { get; set; } = null!;

    public long MessageTime { get; set; }

    public byte EnableBbcode { get; set; }

    public byte EnableSmilies { get; set; }

    public byte EnableMagicUrl { get; set; }

    public byte EnableSig { get; set; }

    public string MessageSubject { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public string MessageEditReason { get; set; } = null!;

    public int MessageEditUser { get; set; }

    public byte MessageAttachment { get; set; }

    public string BbcodeBitfield { get; set; } = null!;

    public string BbcodeUid { get; set; } = null!;

    public long MessageEditTime { get; set; }

    public short MessageEditCount { get; set; }

    public string ToAddress { get; set; } = null!;

    public string BccAddress { get; set; } = null!;

    public byte MessageReported { get; set; }
}
