using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumNotificationEmail
{
    public short NotificationTypeId { get; set; }

    public int ItemId { get; set; }

    public int ItemParentId { get; set; }

    public int UserId { get; set; }
}
