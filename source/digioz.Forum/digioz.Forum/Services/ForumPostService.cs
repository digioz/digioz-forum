using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.Build.Framework;

namespace digioz.Forum.Services
{
    public class ForumPostService : IForumPostService
    {
        private DigiozForumContext _context;

        public ForumPostService(DigiozForumContext context)
        {
            _context = context;
        }

        public ForumPost Get(int id)
        {
            var model = _context.ForumPosts.Where(x => x.PostId == id).SingleOrDefault();
            return model;
        }

        public void Add(ForumPost post)
        {

            _context.ForumPosts.Add(post);
            _context.SaveChanges();
        }

        public List<ForumPost> GetAll()
        {
            var models = _context.ForumPosts.ToList();
            return models;
        }

        public List<ForumPost> GetAllWithUsers()
        {
            var models = (from post in _context.ForumPosts
                          join user in _context.ForumUsers
                          on post.PosterId equals user.ForumUserId into postWithUser
                          select new ForumPost
                          {
                              
                          }).ToList();
            
            //OR

            var models = _context.ForumPosts.Select(x => x.FormUser); //user would be FormUser object joined on ForumUserId

            return models;
        }

        public List<ForumPost> GetAllByForumId(long forumId)
        {
            var models = _context.ForumPosts.Where(x => x.ForumId == forumId).ToList();
            return models;
        }

        public List<ForumPost> GetAllByUserId(int userId)
        {
            var models = _context.ForumPosts.Where(x => x.PosterId == userId).ToList();
            return models;
        }

        public List<ForumPost> GetAllByTopicId(int topicId)
        {
            var models = _context.ForumPosts.Where(x => x.TopicId == topicId).ToList();
            return models;
        }

        public void Edit(ForumPost post)
        {
            var model = _context.ForumPosts.Find(post.PostId);
            if (model != null)
            {
                _context.ForumPosts.Update(post);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var model = _context.ForumPosts.Find(id);
            if (model != null)
            {
                _context.ForumPosts.Remove(model);
                _context.SaveChanges();
            }
        }
    }
}
