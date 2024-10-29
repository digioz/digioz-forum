using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumProfileFieldsDatum
{
    public int UserId { get; set; }

    public string PfForumInterests { get; set; } = null!;

    public string PfForumOccupation { get; set; } = null!;

    public string PfForumLocation { get; set; } = null!;

    public string PfForumSkype { get; set; } = null!;

    public string PfForumFacebook { get; set; } = null!;

    public string PfForumIcq { get; set; } = null!;

    public string PfForumTwitter { get; set; } = null!;

    public string PfForumWebsite { get; set; } = null!;

    public string PfForumYoutube { get; set; } = null!;

    public string PfForumYahoo { get; set; } = null!;
}
