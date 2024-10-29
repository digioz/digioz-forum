using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class Forum
{
    public long ForumId { get; set; }

    public long ParentId { get; set; }

    public long LeftId { get; set; }

    public long RightId { get; set; }

    public string ForumParents { get; set; } = null!;

    public string ForumName { get; set; } = null!;

    public string ForumDesc { get; set; } = null!;

    public string ForumDescBitfield { get; set; } = null!;

    public int ForumDescOptions { get; set; }

    public string ForumDescUid { get; set; } = null!;

    public string ForumLink { get; set; } = null!;

    public string ForumPassword { get; set; } = null!;

    public long ForumStyle { get; set; }

    public string ForumImage { get; set; } = null!;

    public string ForumRules { get; set; } = null!;

    public string ForumRulesLink { get; set; } = null!;

    public string ForumRulesBitfield { get; set; } = null!;

    public int ForumRulesOptions { get; set; }

    public string ForumRulesUid { get; set; } = null!;

    public short ForumTopicsPerPage { get; set; }

    public byte ForumType { get; set; }

    public byte ForumStatus { get; set; }

    public int ForumLastPostId { get; set; }

    public int ForumLastPosterId { get; set; }

    public string ForumLastPostSubject { get; set; } = null!;

    public int ForumLastPostTime { get; set; }

    public string ForumLastPosterName { get; set; } = null!;

    public string ForumLastPosterColour { get; set; } = null!;

    public byte ForumFlags { get; set; }

    public byte DisplayOnIndex { get; set; }

    public byte EnableIndexing { get; set; }

    public byte EnableIcons { get; set; }

    public byte EnablePrune { get; set; }

    public int PruneNext { get; set; }

    public long PruneDays { get; set; }

    public long PruneViewed { get; set; }

    public long PruneFreq { get; set; }

    public byte DisplaySubforumList { get; set; }

    public byte DisplaySubforumLimit { get; set; }

    public int ForumOptions { get; set; }

    public byte EnableShadowPrune { get; set; }

    public long PruneShadowDays { get; set; }

    public long PruneShadowFreq { get; set; }

    public int PruneShadowNext { get; set; }

    public long ForumPostsApproved { get; set; }

    public long ForumPostsUnapproved { get; set; }

    public long ForumPostsSoftdeleted { get; set; }

    public long ForumTopicsApproved { get; set; }

    public long ForumTopicsUnapproved { get; set; }

    public long ForumTopicsSoftdeleted { get; set; }
}
