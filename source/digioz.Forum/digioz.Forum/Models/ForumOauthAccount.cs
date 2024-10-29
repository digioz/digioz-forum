using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumOauthAccount
{
    public int UserId { get; set; }

    public string Provider { get; set; } = null!;

    public string OauthProviderId { get; set; } = null!;
}
