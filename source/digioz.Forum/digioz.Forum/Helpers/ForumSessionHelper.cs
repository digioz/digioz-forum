using digioz.Forum.Models;
using digioz.Forum.Services;
using digioz.Forum.Services.Interfaces;
using System.Security.Claims;

namespace digioz.Forum.Helpers
{
    public class ForumSessionHelper
    {
        private readonly IForumSessionService _forumSessionService;

        public ForumSessionHelper(IForumSessionService forumSessionService)
        {
            _forumSessionService = forumSessionService;
        }

        public void GetSession(HttpContext httpContext, ClaimsPrincipal user)
        {
            var sessionId = httpContext.Session.Id;
            var pageName = httpContext.Request.Path;
            var sessionUserId = user.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            AddSession(httpContext, sessionId, pageName, sessionUserId);
        }

        public int GetForumUserId(string aspNetUserId)
        {
            var forumUserId = _forumSessionService.GetForumUserId(aspNetUserId);
            return forumUserId;
        }

        /// <summary>
        /// Add a session to the database to track user activity
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="sessionId">The unique identifier for the session.</param>
        /// <param name="pageName">The name of the page being visited.</param>
        public void AddSession(HttpContext httpContext, string sessionId, string pageName, string sessionUserId)
        {
            if (!string.IsNullOrEmpty(sessionId))
            {
                var doesSessionExist = _forumSessionService.Get(sessionId);

                if (doesSessionExist == null)
                {
                    var ipAddressHelper = new IpAddressHelper();

                    var dateTimeInt = DateTime.Now.Ticks;
                    var ipAddress = ipAddressHelper.GetIpAddress(httpContext);
                    var browser = ipAddressHelper.GetBrowser(httpContext);
                    var forumUserId = GetForumUserId(sessionUserId);

                    var session = new ForumSession
                    {
                        SessionId = sessionId,
                        SessionUserId = forumUserId,
                        SessionLastVisit = dateTimeInt,
                        SessionStart = dateTimeInt,
                        SessionTime = dateTimeInt,
                        SessionIp = ipAddress,
                        SessionBrowser = browser,
                        SessionForwardedFor = "",
                        SessionPage = pageName,
                        SessionViewOnline = 0,
                        SessionAutoLogin = 0,
                        SessionAdmin = 0,
                        SessionForumId = 0
                    };

                    _forumSessionService.Add(session);
                }
                else
                {
                    UpdateSession(httpContext, sessionId, pageName, sessionUserId);
                }
            }
        }

        /// <summary>
        /// Update a session in the database to track user activity
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="sessionId">The unique identifier for the session.</param>
        /// <param name="pageName">The name of the page being visited.</param>
        public void UpdateSession(HttpContext httpContext, string sessionId, string pageName, string sessionUserId)
        {
            var ipAddressHelper = new IpAddressHelper();
            var session = _forumSessionService.Get(sessionId);
            var dateTimeInt = DateTime.Now.Ticks;
            var ipAddress = ipAddressHelper.GetIpAddress(httpContext);
            var browser = ipAddressHelper.GetBrowser(httpContext);
            if (session != null)
            {
                session.SessionLastVisit = dateTimeInt;
                session.SessionTime = dateTimeInt;
                session.SessionIp = ipAddress;
                session.SessionBrowser = browser;
                session.SessionPage = pageName;
                session.SessionUserId = GetForumUserId(sessionUserId);
                _forumSessionService.Edit(session);
            }
        }
    }
}
