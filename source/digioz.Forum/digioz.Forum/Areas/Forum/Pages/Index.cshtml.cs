using digioz.Forum.Areas.Forum.Pages.Shared;
using digioz.Forum.Data;
using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class IndexModel : BasePageModel
    {
        [BindProperty]
        public List<digioz.Forum.Models.Forum> ForumList { get; set; }

        private readonly ILogger<IndexModel> _logger;
        public readonly IForumService _forumService;    

        public IndexModel(IForumSessionService forumSessionService,
                        IForumPermissionService forumPermissionService,
                        IRoleService roleService,
                        IUserRoleService userRoleService,
                        IForumService forumService,
                        ILogger<IndexModel> logger
                    ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _forumService = forumService;
            _logger = logger;
        }

        public override void OnGet()
        {
            base.OnGet();
            ForumList = _forumService.GetAllByRoleId(Role.Id);

            // Information log entry indicating the page has loaded
            _logger.LogWarning("Forum Index page loaded. RoleId: {RoleId}, SessionId: {SessionId}", Role?.Id, UniqueSessionId); 
        }
    }
}
