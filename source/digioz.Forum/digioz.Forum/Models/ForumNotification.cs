using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumNotification
{
    public int NotificationId { get; set; }

    public short NotificationTypeId { get; set; }

    public long ItemId { get; set; }

    public long ItemParentId { get; set; }

    public int UserId { get; set; }

    public byte NotificationRead { get; set; }

    public long NotificationTime { get; set; }

    public string NotificationData { get; set; } = null!;
}
