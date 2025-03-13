using digioz.Forum.Models;
using digioz.Forum.Models.ViewModels;
using digioz.Forum.Services.Interfaces;
using Microsoft.Build.Framework;


namespace digioz.Forum.Services
{
    public class ForumSessionService : IForumSessionService
    {
        private DigiozForumContext _context;

        public ForumSessionService(DigiozForumContext context)
        {
            _context = context;
        }

        public ForumSession Get(string id)
        {
            var model = _context.ForumSessions.Where(x => x.SessionId == id).SingleOrDefault();
            return model;
        }

        public int GetForumUserId(string aspNetUserId)
        {
            var forumUser = _context.ForumUsers.Where(x => x.UserId == aspNetUserId).SingleOrDefault();
            if (forumUser != null)
            {
                return forumUser.ForumUserId;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<ForumSession> GetAll()
        {
            var models = _context.ForumSessions;
            return models;
        }

        public void Add(ForumSession session)
        {
            _context.ForumSessions.Add(session);
            _context.SaveChanges();
        }

        public void Edit(ForumSession session)
        {
            var model = _context.ForumSessions.Find(session.SessionId);
            if (model != null)
            {
                _context.ForumSessions.Update(session);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var model = _context.ForumSessions.Find(id);
            if (model != null)
            {
                _context.ForumSessions.Remove(model);
                _context.SaveChanges();
            }
        }

        public WhoIsOnlineViewModel GetWhoIsOnline(int duration)
        {
            var model = new WhoIsOnlineViewModel();
            model.UsersOnline = _context.ForumSessions.Where(x => x.SessionTime > System.DateTime.Now.AddMinutes(-duration)).Count();
            model.UsersRegistered = _context.ForumSessions.Where(x => x.SessionTime > System.DateTime.Now.AddMinutes(-duration) && x.SessionUserId != 0).Count();
            model.UsersGuests = model.UsersOnline - model.UsersRegistered;

            return model;
        }

        public StatisticsViewModel GetStatistics()
        {
            var model = new StatisticsViewModel();
            model.TotalMembers = _context.ForumUsers.Count();
            model.TotalPosts = _context.ForumPosts.Count();
            model.TotalTopics = _context.ForumTopics.Count();
            #pragma warning disable CS8601 // Possible null reference assignment.
            model.NewestMember = _context.ForumUsers.OrderByDescending(x => x.UserRegdate).FirstOrDefault();
            #pragma warning restore CS8601 // Possible null reference assignment.

            return model;
        }
    }
}
