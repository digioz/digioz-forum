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
        public bool IsReadOnly { get; set; } = false;
        [BindProperty]
        public List<ForumPost> Posts { get; private set; } = new();
        [BindProperty]
        public long TopicId { get; private set; }

        private readonly IForumService _forumService;
        private readonly IForumTopicService _forumTopicService;
        private readonly IForumPostService _forumPostService;
        private readonly IForumPermissionService _forumPermissionService;

        public ViewTopicModel(
            IForumSessionService forumSessionService,
            IForumPermissionService forumPermissionService,
            IRoleService roleService,
            IUserRoleService userRoleService,
            IForumService forumService,
            IForumTopicService forumTopicService,
            IForumPostService forumPostService
        ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _forumService = forumService;
            _forumTopicService = forumTopicService;
            _forumPostService = forumPostService;
            _forumPermissionService = forumPermissionService;
        }

        public override void OnGet()
        {
            base.OnGet();

            if (!Request.Query.TryGetValue("t", out var tValues) || !long.TryParse(tValues.FirstOrDefault(), out var t))
                return;

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
        }
    }
}
