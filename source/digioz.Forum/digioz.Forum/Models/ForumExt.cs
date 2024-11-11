using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace digioz.Forum.Models;

public partial class ForumExt
{
    [Key]
    public string ExtName { get; set; } = null!;

    public byte ExtActive { get; set; }

    public string ExtState { get; set; } = null!;
}
