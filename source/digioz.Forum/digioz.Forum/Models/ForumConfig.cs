using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace digioz.Forum.Models;

public partial class ForumConfig
{
    [Key]
    public string ConfigName { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public byte IsDynamic { get; set; }
}
