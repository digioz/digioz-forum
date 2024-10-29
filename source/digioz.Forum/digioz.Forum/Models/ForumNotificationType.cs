using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumNotificationType
{
    public short NotificationTypeId { get; set; }

    public string NotificationTypeName { get; set; } = null!;

    public byte NotificationTypeEnabled { get; set; }
}
