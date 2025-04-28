using digioz.Forum.Helpers;
using digioz.Forum.Pages.Shared;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Acp
{
    [Authorize(Roles = "Administrators")]
    public class IndexModel : BasePageModel
    {
        public IndexModel(IForumSessionService forumSessionService,
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
