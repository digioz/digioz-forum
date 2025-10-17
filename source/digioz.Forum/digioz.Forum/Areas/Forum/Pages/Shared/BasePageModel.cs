using System.Security.Claims;
using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Shared
{
    public abstract class BasePageModel : PageModel
    {
        public string UniqueSessionId { get; private set; }

        [BindProperty]
        public AspNetRole Role { get; set; }

        [BindProperty]
        public List<ForumPermission> Permissions { get; set; }

        [BindProperty]
        public UserHelper UserHelperInstance { get; set; }

        private readonly IForumSessionService _forumSessionService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoleService _roleService;
        private readonly IUserRoleService _userRoleService;
        private readonly IForumPermissionService _forumPermissionService;

        public BasePageModel(IForumSessionService forumSessionService, IForumPermissionService forumPermissionService
                            , IRoleService roleService, IUserRoleService userRoleService)
        {
            _forumSessionService = forumSessionService;
            UniqueSessionId = string.Empty;
            _forumPermissionService = forumPermissionService;
            _httpContextAccessor = new HttpContextAccessor();
            _roleService = roleService;
            _userRoleService = userRoleService;
        }

        public virtual void OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UniqueSessionId")))
            {
                HttpContext.Session.SetString("UniqueSessionId", Guid.NewGuid().ToString());
            }

            UniqueSessionId = HttpContext.Session.GetString("UniqueSessionId") ?? string.Empty;

            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User, UniqueSessionId);

            UserHelperInstance = new UserHelper(_httpContextAccessor, _roleService, _userRoleService);

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Role = UserHelperInstance.GetUserRoleId(userId);
            }
            else
            {
                Role = UserHelperInstance.GetUserRoleId(null);
            }
        }
    }
}
