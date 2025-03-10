using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumLog
{
    public int LogId { get; set; }

    public byte LogType { get; set; }

    public int UserId { get; set; }

    public long ForumId { get; set; }

    public int TopicId { get; set; }

    public int PostId { get; set; }

    public int ReporteeId { get; set; }

    public string LogIp { get; set; } = null!;

    public DateTime? LogTime { get; set; }

    public string LogOperation { get; set; } = null!;

    public string LogData { get; set; } = null!;
}
