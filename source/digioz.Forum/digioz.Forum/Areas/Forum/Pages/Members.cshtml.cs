using digioz.Forum.Areas.Forum.Pages.Shared;
using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class MembersModel : BasePageModel
    {
        public MembersModel(IForumSessionService forumSessionService,
                        IForumPermissionService forumPermissionService,
                        IRoleService roleService,
                        IUserRoleService userRoleService
                    ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
        }

        public override void OnGet()
        {
            base.OnGet();

        }
    }
}
