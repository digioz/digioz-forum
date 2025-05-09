﻿using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace digioz.Forum.Helpers
{
    public class UserHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoleService _roleService;
        private readonly IUserRoleService _userRoleService;

        public UserHelper(IHttpContextAccessor httpContextAccessor, IRoleService roleService, IUserRoleService userRoleService)
        {
            _httpContextAccessor = httpContextAccessor;
            _roleService = roleService;
            _userRoleService = userRoleService;
        }

        public string GetUserId()
        {
            var userId = "";
            var user = _httpContextAccessor.HttpContext?.User?.Identity?.Name;
            if (user != null)
            {
                userId = user;
            }
            return userId;
        }

        public string GetForumUserName(string email)
        {
            var forumUserName = "";

            var context = new DigiozForumContext();
            var user = context.ForumUsers.FirstOrDefault(x => x.UserEmail == email);

            if (user != null)
            {
                forumUserName = user.UserName;
            }

            return forumUserName;
        }

        public ForumUser GetForumUser(string email)
        {
            var context = new DigiozForumContext();
            var user = context.ForumUsers.FirstOrDefault(x => x.UserEmail == email);
            return user;
        }

        public int GetUserType(string name)
        {
            var userType = 0;

            if (name == "USER_NORMAL")
            {
                userType = 0;
            }
            else if (name == "USER_INACTIVE")
            {
                userType = 1;
            }
            else if (name == "USER_IGNORE")
            {
                userType = 2;
            }
            else if (name == "USER_FOUNDER")
            {
                userType = 3;
            }
            else
            {
                userType = 0;
            }

            return userType;
        }

        public ForumUser GetDefaultUser()
        {
            var dateStamp = DateTime.Now;

            var user = new ForumUser()
            {
                ForumUserId = 0,
                UserId = string.Empty,
                UserType = 0,
                GroupId = 2,
                UserPermissions = string.Empty,
                UserPermFrom = 0,
                UserIp = string.Empty,
                UserRegdate = dateStamp,
                UserName = string.Empty,
                UserNameClean = string.Empty,
                UserEmail = string.Empty,
                UserBirthday = string.Empty,
                UserLastVisit = dateStamp,
                UserLastActive = dateStamp,
                UserLastMark = dateStamp,
                UserLastPostTime = null,
                UserLastPage = string.Empty,
                UserLastConfirmKey = string.Empty,
                UserLastSearch = null,
                UserWarnings = 0,
                UserLastWarning = null,
                UserLoginAttempts = 0,
                UserInactiveReason = 0,
                UserInactiveTime = null,
                UserPosts = 0,
                UserLang = "en",
                UserTimeZone = "UTC",
                UserDateFormat = "D M d, Y g:i a",
                UserStyle = 1,
                UserRank = 0,
                UserColor = string.Empty,
                UserNewPrivmsg = 0,
                UserUnreadPrivmsg = 0,
                UserLastPrivmsg = null,
                UserMessageRules = 0,
                UserFullFolder = -3,
                UserEmailTime = null,
                UserTopicShowDays = 0,
                UserTopicSortbyType = "t",
                UserTopicSortbyDir = "d",
                UserPostShowDays = 0,
                UserPostSortbyType = "t",
                UserPostSortbyDir = "a",
                UserNotify = 0,
                UserNotifyPm = 1,
                UserNotifyType = 0,
                UserAllowPm = 1,
                UserAllowViewOnline = 1,
                UserAllowViewEmail = 1,
                UserAllowMassemail = 1,
                UserOptions = 230271,
                UserAvatar = string.Empty,
                UserAvatarType = string.Empty,
                UserAvatarWidth = 0,
                UserAvatarHeight = 0,
                UserSig = string.Empty,
                UserSigBbcodeUid = string.Empty,
                UserSigBbcodeBitfield = string.Empty,
                UserJabber = string.Empty,
                UserActkey = string.Empty,
                UserActkeyExpiration = null,
                ResetToken = string.Empty,
                ResetTokenExpiration = null,
                UserNewpasswd = string.Empty,
                UserFormSalt = string.Empty,
                UserNew = 1,
                UserReminded = 0,
                UserRemindedTime = null
            };
            return user;
        }

        public AspNetRole GetUserRoleId(string aspNetUserId)
        {
            var roleId = string.Empty;
            var role = new AspNetRole();
            var roles = _roleService.GetAllDictionary();
            var userRoles = _userRoleService.GetAllDictionary(aspNetUserId);

            if (aspNetUserId.IsNullOrEmpty())
            {
                roleId = roles.FirstOrDefault(x => x.Value == "Guests").Key;
            }
            else
            {
                if (userRoles.ContainsValue("Administrators"))
                {
                    roleId = roles.FirstOrDefault(x => x.Value == "Administrators").Key;
                }
                else if (userRoles.ContainsValue("Moderators"))
                {
                    roleId = roles.FirstOrDefault(x => x.Value == "Moderators").Key;
                }
                else if (userRoles.ContainsValue("Registered"))
                {
                    roleId = roles.FirstOrDefault(x => x.Value == "Registered").Key; 
                }
                else
                {
                    roleId = roles.FirstOrDefault(x => x.Value == "Guests").Key;
                }
            }

            role = _roleService.Get(roleId);

            return role;
        }
    }
}
