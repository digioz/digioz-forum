using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumLog
{
    public long LogId { get; set; }

    public byte LogType { get; set; }

    public int UserId { get; set; }

    public long ForumId { get; set; }

    public long TopicId { get; set; }

    public long PostId { get; set; }

    public int ReporteeId { get; set; }

    public string LogIp { get; set; } = null!;

    public DateTime? LogTime { get; set; }

    public string LogOperation { get; set; } = null!;

    public string LogData { get; set; } = null!;
}
