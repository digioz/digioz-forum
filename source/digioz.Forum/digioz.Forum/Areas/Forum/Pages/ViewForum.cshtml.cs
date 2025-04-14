using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Services;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class ViewForumModel : PageModel
    {
        [BindProperty]
        public digioz.Forum.Models.Forum ForumInstance { get; set; }

        [BindProperty]
        public List<ForumPost> Posts { get; set; }

        public string UniqueSessionId { get; private set; }

        [BindProperty]
        public AspNetRole Role { get; set; }

        private readonly IForumSessionService _forumSessionService;
        private readonly ILogger<IndexModel> _logger;
        private readonly IForumService _forumService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoleService _roleService;
        private readonly IUserRoleService _userRoleService;
        private readonly IForumPostService _forumPostService;

        public ViewForumModel(ILogger<IndexModel> logger, IForumSessionService forumSessionService
                         , IForumService forumService, IHttpContextAccessor httpContextAccessor
                         , IRoleService roleService, IUserRoleService userRoleService
                         , IForumPostService forumPostService)
        {
            _logger = logger;
            _forumSessionService = forumSessionService;
            _forumService = forumService;
            _httpContextAccessor = httpContextAccessor;
            _roleService = roleService;
            _userRoleService = userRoleService;
            _forumPostService = forumPostService;
        }

        public void OnGet(int f)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UniqueSessionId")))
            {
                HttpContext.Session.SetString("UniqueSessionId", Guid.NewGuid().ToString());
            }

            UniqueSessionId = HttpContext.Session.GetString("UniqueSessionId");

            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User, UniqueSessionId);
            var userHelper = new UserHelper(_httpContextAccessor, _roleService, _userRoleService);

            // Get Forum Instance
            if (f > 0)
            {
                if (User.Identity.IsAuthenticated)
                {
                    var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    Role = userHelper.GetUserRoleId(userId);
                }
                else
                {
                    Role = userHelper.GetUserRoleId(null);
                }

                var forums = _forumService.GetAllByRoleId(Role.Id);

                ForumInstance = forums.Where(x => x.ForumId == f).SingleOrDefault();

                if (ForumInstance == null)
                {
                    // Redirect to Forum Index since user does not
                    // have permission to view this forum
                    Response.Redirect("/Forum/Index");
                }
            }

            // Get all Forum Posts by Forum Id
            if (ForumInstance != null)
            {
                Posts = _forumPostService.GetAllByForumId(ForumInstance.ForumId);
            }
        }
    }
}
