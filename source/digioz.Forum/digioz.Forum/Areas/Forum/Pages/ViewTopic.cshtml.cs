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
        public ForumTopic Topic { get; set; }

        [BindProperty]
        public List<ForumPost> Posts { get; set; }

        private readonly IForumTopicService _topicService;
        private readonly IForumPostService _postService;
        private readonly IForumService _forumService;

        public ViewTopicModel(IForumSessionService forumSessionService,
                        IForumPermissionService forumPermissionService,
                        IForumService forumService,
                        IRoleService roleService,
                        IUserRoleService userRoleService,
                        IForumTopicService topicService, IForumPostService postService
                    ) : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _topicService = topicService;
            _postService = postService;
            _forumService = forumService;
        }

        public override void OnGet()
        {
            base.OnGet();

            if (t.HasValue)
            {
                Topic = _topicService.Get(t.Value);
                Posts = _postService.GetAllByTopicId(t.Value);
            }
        }
    }
}
