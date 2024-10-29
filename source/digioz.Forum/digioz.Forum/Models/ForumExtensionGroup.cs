using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumExtensionGroup
{
    public long GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public byte CatId { get; set; }

    public byte AllowGroup { get; set; }

    public byte DownloadMode { get; set; }

    public string UploadIcon { get; set; } = null!;

    public int MaxFileSize { get; set; }

    public string AllowedForums { get; set; } = null!;

    public byte AllowInPm { get; set; }
}
