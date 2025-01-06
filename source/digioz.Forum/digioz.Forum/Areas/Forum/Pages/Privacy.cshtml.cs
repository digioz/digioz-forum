﻿using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IForumSessionService _forumConfigService;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger, IForumSessionService forumSessionService)
        {
            _logger = logger;
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
