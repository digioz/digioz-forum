using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IForumSessionService _forumSessionService;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger, IForumSessionService forumSessionService)
        {
            _logger = logger;
            _forumSessionService = forumSessionService;
        }

        public void OnGet()
        {
            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User);
        }
    }

}
