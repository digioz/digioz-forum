using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumModule
{
    public long ModuleId { get; set; }

    public byte ModuleEnabled { get; set; }

    public byte ModuleDisplay { get; set; }

    public string ModuleBasename { get; set; } = null!;

    public string ModuleClass { get; set; } = null!;

    public long ParentId { get; set; }

    public long LeftId { get; set; }

    public long RightId { get; set; }

    public string ModuleLangname { get; set; } = null!;

    public string ModuleMode { get; set; } = null!;

    public string ModuleAuth { get; set; } = null!;
}
