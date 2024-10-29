using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumConfig
{
    public string ConfigName { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public byte IsDynamic { get; set; }
}
