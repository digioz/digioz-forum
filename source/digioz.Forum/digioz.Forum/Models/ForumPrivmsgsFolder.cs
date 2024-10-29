using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPrivmsgsFolder
{
    public long FolderId { get; set; }

    public int UserId { get; set; }

    public string FolderName { get; set; } = null!;

    public long PmCount { get; set; }
}
