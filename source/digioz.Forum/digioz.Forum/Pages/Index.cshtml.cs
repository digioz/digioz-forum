using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IForumSessionService _forumConfigService;

        public IndexModel(IForumSessionService forumSessionService)
        {
            _forumConfigService = forumSessionService;
        }

        private void GetSession()
        {
            var sessionId = HttpContext.Session.Id;
            var pageName = Request.Path;
            var forumSessionHelper = new ForumSessionHelper(_forumConfigService);
            forumSessionHelper.AddSession(HttpContext, sessionId, pageName);
        }

        public void OnGet()
        {
            GetSession();
        }
    }
}
