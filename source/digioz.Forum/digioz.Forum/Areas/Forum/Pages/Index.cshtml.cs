using digioz.Forum.Areas.Forum.Pages.Shared;
using digioz.Forum.Data;
using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class IndexModel : BasePageModel
    {
        [BindProperty]
        public List<digioz.Forum.Models.Forum> ForumList { get; set; }

        public readonly IForumService _forumService;    

        public IndexModel(IForumSessionService forumSessionService,
                        IForumPermissionService forumPermissionService,
                        IRoleService roleService,
                        IUserRoleService userRoleService,
                        IForumService forumService
                    ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _forumService = forumService;
        }

        public override void OnGet()
        {
            base.OnGet();
            ForumList = _forumService.GetAllByRoleId(Role.Id);
        }
    }
}
