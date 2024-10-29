using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSiteList
{
    public long SiteId { get; set; }

    public string SiteIp { get; set; } = null!;

    public string SiteHostName { get; set; } = null!;

    public byte IpExclude { get; set; }
}
