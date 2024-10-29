using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumUserNotification
{
    public string ItemType { get; set; } = null!;

    public int ItemId { get; set; }

    public int UserId { get; set; }

    public string Method { get; set; } = null!;

    public byte Notify { get; set; }
}
