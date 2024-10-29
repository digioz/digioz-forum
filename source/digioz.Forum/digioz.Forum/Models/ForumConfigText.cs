using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumConfigText
{
    public string ConfigName { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;
}
