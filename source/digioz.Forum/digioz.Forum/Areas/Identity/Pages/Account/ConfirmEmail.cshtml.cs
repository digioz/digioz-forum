// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using digioz.Forum.Helpers;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace digioz.Forum.Areas.Identity.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        public string UniqueSessionId { get; private set; }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly IForumSessionService _forumSessionService;

        public ConfirmEmailModel(UserManager<IdentityUser> userManager, IForumSessionService forumSessionService)
        {
            _userManager = userManager;
            _forumSessionService = forumSessionService;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UniqueSessionId")))
            {
                HttpContext.Session.SetString("UniqueSessionId", Guid.NewGuid().ToString());
            }

            UniqueSessionId = HttpContext.Session.GetString("UniqueSessionId");

            var forumSessionHelper = new ForumSessionHelper(_forumSessionService);
            forumSessionHelper.GetSession(HttpContext, User, UniqueSessionId);

            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";
            return Page();
        }
    }
}
