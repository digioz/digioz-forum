using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class UcpModel : PageModel
    {
        private readonly IForumSessionService _forumSessionService;

        public UcpModel(IForumSessionService forumSessionService)
        {
            _forumSessionService = forumSessionService;
        }

        public void OnGet()
        {
            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User);
        }
    }
}
