using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPost
{
    public long PostId { get; set; }

    public long TopicId { get; set; }

    public long ForumId { get; set; }

    public int PosterId { get; set; }

    public long IconId { get; set; }

    public string PosterIp { get; set; } = null!;

    public DateTime? PostTime { get; set; }

    public byte PostReported { get; set; }

    public byte EnableBbcode { get; set; }

    public byte EnableSmilies { get; set; }

    public byte EnableMagicUrl { get; set; }

    public byte EnableSig { get; set; }

    public string PostUsername { get; set; } = null!;

    public string PostSubject { get; set; } = null!;

    public string PostText { get; set; } = null!;

    public string PostChecksum { get; set; } = null!;

    public byte PostAttachment { get; set; }

    public string BbcodeBitfield { get; set; } = null!;

    public string BbcodeUid { get; set; } = null!;

    public byte PostCount { get; set; }

    public DateTime? PostEditTime { get; set; }

    public string PostEditReason { get; set; } = null!;

    public int PostEditUser { get; set; }

    public short PostEditCount { get; set; }

    public byte PostEditLocked { get; set; }

    public byte PostVisibility { get; set; }

    public DateTime? PostDeleteTime { get; set; }

    public string PostDeleteReason { get; set; } = null!;

    public int PostDeleteUser { get; set; }
    public ForumUser FormUser { get; set; } // for the linking
}
