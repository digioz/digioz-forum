using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumOauthState
{
    public int UserId { get; set; }

    public string SessionId { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public string OauthState { get; set; } = null!;
}
