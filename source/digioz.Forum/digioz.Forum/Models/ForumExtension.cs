using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumExtension
{
    public long ExtensionId { get; set; }

    public long GroupId { get; set; }

    public string Extension { get; set; } = null!;
}
