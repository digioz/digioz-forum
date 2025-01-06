using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;

namespace digioz.Forum.Helpers
{
    public class ForumSessionHelper
    {
        private readonly IForumSessionService _forumSessionService;

        public ForumSessionHelper(IForumSessionService forumSessionService)
        {
            _forumSessionService = forumSessionService;
        }

        /// <summary>
        /// Add a session to the database to track user activity
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="sessionId">The unique identifier for the session.</param>
        /// <param name="pageName">The name of the page being visited.</param>
        public void AddSession(HttpContext httpContext, string sessionId, string pageName)
        {
            var doesSessionExist = _forumSessionService.Get(sessionId);

            if (doesSessionExist == null)
            {
                var ipAddressHelper = new IpAddressHelper();

                var dateTimeInt = DateTime.Now.Ticks;
                var ipAddress = ipAddressHelper.GetIpAddress(httpContext);
                var browser = ipAddressHelper.GetBrowser(httpContext);

                var session = new ForumSession
                {
                    SessionId = sessionId,
                    SessionUserId = 0,
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
                UpdateSession(httpContext, sessionId, pageName);
            }
        }

        /// <summary>
        /// Update a session in the database to track user activity
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="sessionId">The unique identifier for the session.</param>
        /// <param name="pageName">The name of the page being visited.</param>
        public void UpdateSession(HttpContext httpContext, string sessionId, string pageName)
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
                _forumSessionService.Edit(session);
            }
        }
    }
}
