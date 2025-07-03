using digioz.Forum.Helpers;
using digioz.Forum.Models;
using digioz.Forum.Pages.Shared;
using digioz.Forum.Services;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class ViewForumModel : BasePageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? f { get; set; }


        [BindProperty]
        public digioz.Forum.Models.Forum ForumInstance { get; set; }

        [BindProperty]
        public List<ForumTopic> Topics { get; set; }

        [BindProperty]
        public bool IsReadOnly { get; set; } = false;

        private readonly IForumSessionService _forumSessionService;
        private readonly ILogger<IndexModel> _logger;
        private readonly IForumService _forumService;
        private readonly IForumPostService _forumPostService;
        private readonly IForumTopicService _forumTopicService;
        private readonly IForumPermissionService _forumPermissionService;

        public ViewForumModel(ILogger<IndexModel> logger, IForumSessionService forumSessionService
                         , IForumService forumService, IHttpContextAccessor httpContextAccessor
                         , IRoleService roleService, IUserRoleService userRoleService
                         , IForumPostService forumPostService, IForumTopicService forumTopicService
                         , IForumPermissionService forumPermissionService) 
                         : base(forumSessionService, forumPermissionService, roleService, userRoleService)
        {
            _logger = logger;
            _forumSessionService = forumSessionService;
            _forumService = forumService;
            _forumPostService = forumPostService;
            _forumTopicService = forumTopicService;
            _forumPermissionService = forumPermissionService;
        }

        public override void OnGet()
        {
            base.OnGet();

            if (f.HasValue)
            {
                // Determine if forum is read-only
                IsReadOnly = _forumPermissionService.IsReadOnly(f.Value, Role?.Id);

                // Get Forum Instance
                var forums = _forumService.GetAllByRoleId(Role?.Id);

                ForumInstance = forums.SingleOrDefault(x => x.ForumId == f.Value);

                if (ForumInstance == null)
                {
                    // Redirect to Forum Index since user does not
                    // have permission to view this forum
                    Response.Redirect("/Forum/Index");
                    return; // Ensure no further code is executed
                }

                // Get all Forum Posts by Forum Id
                Topics = _forumTopicService.GetAllByForumId(ForumInstance.ForumId)
                    .Where(x => x.TopicVisibility == 1)
                    .ToList();

                // Get Forum Permissions
                Permissions = _forumPermissionService.GetAllByForumId(ForumInstance.ForumId);
            }
        }
    }
}
