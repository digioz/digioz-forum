using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Mcp
{
    [Authorize(Roles = "Moderator,Administrator")]
    public class IndexModel : PageModel
    {
        public string UniqueSessionId { get; private set; }

        private readonly IForumSessionService _forumSessionService;

        public IndexModel(IForumSessionService forumSessionService)
        {
            _forumSessionService = forumSessionService;
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
        }
    }
}
