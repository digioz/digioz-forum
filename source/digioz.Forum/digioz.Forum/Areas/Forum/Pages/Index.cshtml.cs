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
        private readonly IForumSessionService _forumConfigService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IForumSessionService forumSessionService)
        {
            _logger = logger;
            _forumConfigService = forumSessionService;
        }

        private void GetSession()
        {
            var sessionId = HttpContext.Session.Id;
            var pageName = Request.Path;
            var forumSessionHelper = new ForumSessionHelper(_forumConfigService);
            var sessionUserId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            forumSessionHelper.AddSession(HttpContext, sessionId, pageName, sessionUserId);
        }

        public void OnGet()
        {
            GetSession();

            var context = new DigiozForumContext();
            var users = context.AspNetUsers.ToList();
        }
    }
}
