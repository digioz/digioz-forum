using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Pages.Shared;
using digioz.Forum.Services;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class ViewTopicModel : BasePageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? t { get; set; }

        [BindProperty]
        public digioz.Forum.Models.Forum ForumInstance { get; set; }

        [BindProperty]
        public ForumTopic Topic { get; set; }

        [BindProperty]
        public ForumUser CurrentUser { get; set; } = new ForumUser();

        [BindProperty]
        public List<ForumUser> PostUsers { get; private set; } = new();

        [BindProperty]
        public bool IsReadOnly { get; set; } = false;
        [BindProperty]
        public List<ForumPost> Posts { get; private set; } = new();
        [BindProperty]
        public long TopicId { get; private set; }

        [BindProperty]
        public Dictionary<string, string> Configs { get; set; }

        private readonly IForumService _forumService;
        private readonly IForumTopicService _forumTopicService;
        private readonly IForumPostService _forumPostService;
        private readonly IForumPermissionService _forumPermissionService;
        private readonly IForumUserService _forumUserService;

        public ViewTopicModel(
            IForumSessionService forumSessionService,
            IForumPermissionService forumPermissionService,
            IRoleService roleService,
            IUserRoleService userRoleService,
            IForumService forumService,
            IForumTopicService forumTopicService,
            IForumPostService forumPostService,
            IForumUserService forumUserService
        ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _forumService = forumService;
            _forumTopicService = forumTopicService;
            _forumPostService = forumPostService;
            _forumPermissionService = forumPermissionService;
            _forumUserService = forumUserService;
            var configHelper = new ConfigHelper();
            Configs = configHelper.GetForumConfigs();
        }

        public override void OnGet()
        {
            base.OnGet();

            if (!Request.Query.TryGetValue("t", out var tValues) || !long.TryParse(tValues.FirstOrDefault(), out var t))
                return;

            // Check if user is logged in
            if (User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                CurrentUser = _forumUserService.GetByUserId(userId);
            }

            TopicId = t;
            Topic = _forumTopicService.Get(t);

            var f = Topic?.ForumId;
            if (!f.HasValue)
            {
                Response.Redirect("/Forum/Index");
                return;
            }

            IsReadOnly = _forumPermissionService.IsReadOnly(f.Value, Role?.Id);

            var forums = _forumService.GetAllByRoleId(Role?.Id) ?? new List<digioz.Forum.Models.Forum>();
            ForumInstance = forums.SingleOrDefault(x => x.ForumId == f.Value);

            if (ForumInstance == null)
            {
                Response.Redirect("/Forum/Index");
                return;
            }

            Permissions = _forumPermissionService.GetAllByForumId(ForumInstance.ForumId);
            Posts = _forumPostService.GetAllByTopicId(t).OrderBy(x => x.PostTime).ToList();
            PostUsers = _forumUserService.GetByPosts(Posts);
        }
    }
}
