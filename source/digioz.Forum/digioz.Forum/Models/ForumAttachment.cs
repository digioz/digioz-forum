using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumAttachment
{
    public int AttachId { get; set; }

    public int PostMsgId { get; set; }

    public int TopicId { get; set; }

    public byte InMessage { get; set; }

    public int PosterId { get; set; }

    public byte IsOrphan { get; set; }

    public string PhysicalFilename { get; set; } = null!;

    public string RealFilename { get; set; } = null!;

    public long DownloadCount { get; set; }

    public string AttachComment { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public int FileSize { get; set; }

    public long FileTime { get; set; }

    public byte Thumbnail { get; set; }
}
