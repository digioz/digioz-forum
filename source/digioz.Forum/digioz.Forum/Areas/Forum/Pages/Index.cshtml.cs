using digioz.Forum.Data;
using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<digioz.Forum.Models.Forum> ForumList { get; set; }

        public string UniqueSessionId { get; private set; }

        [BindProperty]
        public AspNetRole Role { get; set; }

        private readonly IForumSessionService _forumSessionService;
        private readonly ILogger<IndexModel> _logger;
        private readonly IForumService _forumService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoleService _roleService;
        private readonly IUserRoleService _userRoleService;

        public IndexModel(ILogger<IndexModel> logger, IForumSessionService forumSessionService
                         , IForumService forumService, IHttpContextAccessor httpContextAccessor
                         , IRoleService roleService, IUserRoleService userRoleService)
        {
            _logger = logger;
            _forumSessionService = forumSessionService;
            _forumService = forumService;
            _httpContextAccessor = httpContextAccessor;
            _roleService = roleService;
            _userRoleService = userRoleService;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UniqueSessionId")))
            {
                HttpContext.Session.SetString("UniqueSessionId", Guid.NewGuid().ToString());
            }

            UniqueSessionId = HttpContext.Session.GetString("UniqueSessionId");

            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User, UniqueSessionId);
            var userHelper = new UserHelper(_httpContextAccessor, _roleService, _userRoleService);

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Role = userHelper.GetUserRoleId(userId);
            }
            else
            {
                Role = userHelper.GetUserRoleId(null);
            }

            ForumList = _forumService.GetAllByRoleId(Role.Id);
        }
    }
}
