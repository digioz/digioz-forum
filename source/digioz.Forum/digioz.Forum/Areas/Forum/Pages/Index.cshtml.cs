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
        private readonly IForumSessionService _forumSessionService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IForumSessionService forumSessionService)
        {
            _logger = logger;
            _forumSessionService = forumSessionService;
        }

        public void OnGet()
        {
            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User);

            var context = new DigiozForumContext();
            var users = context.AspNetUsers.ToList();
        }
    }
}
