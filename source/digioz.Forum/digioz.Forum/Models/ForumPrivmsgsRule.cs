using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumPrivmsgsRule
{
    public long RuleId { get; set; }

    public int UserId { get; set; }

    public long RuleCheck { get; set; }

    public long RuleConnection { get; set; }

    public string RuleString { get; set; } = null!;

    public int RuleUserId { get; set; }

    public long RuleGroupId { get; set; }

    public long RuleAction { get; set; }

    public int RuleFolderId { get; set; }
}
