using digioz.Forum.Areas.Forum.Pages.Shared;
using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Acp
{
    [Authorize(Roles = "Administrators")]
    public class SystemSettingsManagerModel : BasePageModel
    {
        public SystemSettingsManagerModel(IForumSessionService forumSessionService,
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
