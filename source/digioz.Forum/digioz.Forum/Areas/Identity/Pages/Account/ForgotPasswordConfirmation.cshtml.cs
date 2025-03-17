// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace digioz.Forum.Areas.Identity.Pages.Account
{
    /// <summary>
    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    [AllowAnonymous]
    public class ForgotPasswordConfirmation : PageModel
    {
        public string UniqueSessionId { get; private set; }

        private readonly IForumSessionService _forumSessionService;

        public ForgotPasswordConfirmation(IForumSessionService forumSessionService)
        {
            _forumSessionService = forumSessionService;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
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
