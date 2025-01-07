using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;

namespace digioz.Forum.Services
{
    public class ForumUserService : IForumUserService
    {
        private DigiozForumContext _context;

        public ForumUserService(DigiozForumContext context)
        {
            _context = context;
        }

        public ForumUser Get(int id)
        {
            var model = _context.ForumUsers.Find(id);
            return model;
        }

        public List<ForumUser> GetAll()
        {
            var models = _context.ForumUsers.ToList();
            return models;
        }

        public void Add(ForumUser ForumUser)
        {
            _context.ForumUsers.Add(ForumUser);
            _context.SaveChanges();
        }

        public void Edit(ForumUser ForumUser)
        {
            var model = _context.ForumUsers.Find(ForumUser.ForumUserId);
            if (model != null)
            {
                _context.ForumUsers.Update(ForumUser);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var model = _context.ForumUsers.Find(id);
            if (model != null)
            {
                _context.ForumUsers.Remove(model);
                _context.SaveChanges();
            }
        }

        public bool DoesUserExist(string userId)
        {
            var model = _context.ForumUsers.Where(x => x.UserId == userId).SingleOrDefault();
            return model != null;
        }

        public bool DoesForumUserExist(int forumUserId)
        {
            var model = _context.ForumUsers.Where(x => x.ForumUserId == forumUserId).SingleOrDefault();
            return model != null;
        }

        public bool DoesForumUsernameExist(string username)
        {
            var model = _context.ForumUsers.Where(x => x.UserName == username).SingleOrDefault();
            return model != null;
        }
    }
}
