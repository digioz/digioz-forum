using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumUser
{
    public int ForumUserId { get; set; }

    public string UserId { get; set; } = null!;

    public byte UserType { get; set; }

    public long GroupId { get; set; }

    public string UserPermissions { get; set; } = null!;

    public long UserPermFrom { get; set; }

    public string UserIp { get; set; } = null!;

    public int UserRegdate { get; set; }

    public string UserName { get; set; } = null!;

    public string UserNameClean { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserBirthday { get; set; } = null!;

    public int UserLastVisit { get; set; }

    public int UserLastActive { get; set; }

    public int UserLastMark { get; set; }

    public int UserLastPostTime { get; set; }

    public string UserLastPage { get; set; } = null!;

    public string UserLastConfirmKey { get; set; } = null!;

    public int UserLastSearch { get; set; }

    public byte UserWarnings { get; set; }

    public int UserLastWarning { get; set; }

    public byte UserLoginAttempts { get; set; }

    public byte UserInactiveReason { get; set; }

    public int UserInactiveTime { get; set; }

    public long UserPosts { get; set; }

    public string UserLang { get; set; } = null!;

    public string UserTimeZone { get; set; } = null!;

    public string UserDateFormat { get; set; } = null!;

    public long UserStyle { get; set; }

    public long UserRank { get; set; }

    public string UserColor { get; set; } = null!;

    public int UserNewPrivmsg { get; set; }

    public int UserUnreadPrivmsg { get; set; }

    public int UserLastPrivmsg { get; set; }

    public byte UserMessageRules { get; set; }

    public int UserFullFolder { get; set; }

    public int UserEmailTime { get; set; }

    public short UserTopicShowDays { get; set; }

    public string UserTopicSortbyType { get; set; } = null!;

    public string UserTopicSortbyDir { get; set; } = null!;

    public short UserPostShowDays { get; set; }

    public string UserPostSortbyType { get; set; } = null!;

    public string UserPostSortbyDir { get; set; } = null!;

    public byte UserNotify { get; set; }

    public byte UserNotifyPm { get; set; }

    public byte UserNotifyType { get; set; }

    public byte UserAllowPm { get; set; }

    public byte UserAllowViewOnline { get; set; }

    public byte UserAllowViewEmail { get; set; }

    public byte UserAllowMassemail { get; set; }

    public int UserOptions { get; set; }

    public string UserAvatar { get; set; } = null!;

    public string UserAvatarType { get; set; } = null!;

    public short UserAvatarWidth { get; set; }

    public short UserAvatarHeight { get; set; }

    public string UserSig { get; set; } = null!;

    public string UserSigBbcodeUid { get; set; } = null!;

    public string UserSigBbcodeBitfield { get; set; } = null!;

    public string UserJabber { get; set; } = null!;

    public string UserActkey { get; set; } = null!;

    public int UserActkeyExpiration { get; set; }

    public string ResetToken { get; set; } = null!;

    public int ResetTokenExpiration { get; set; }

    public string UserNewpasswd { get; set; } = null!;

    public string UserFormSalt { get; set; } = null!;

    public byte UserNew { get; set; }

    public byte UserReminded { get; set; }

    public int UserRemindedTime { get; set; }
}
