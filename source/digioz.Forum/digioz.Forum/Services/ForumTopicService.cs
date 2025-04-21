using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.Build.Framework;

namespace digioz.Forum.Services
{
    public class ForumTopicService : IForumTopicService
    {
        private DigiozForumContext _context;

        public ForumTopicService(DigiozForumContext context)
        {
            _context = context;
        }

        public ForumTopic Get(long id)
        {
            return _context.ForumTopics.FirstOrDefault(x => x.TopicId == id);
        }

        public List<ForumTopic> GetAll()
        {
            return _context.ForumTopics.ToList();
        }

        public List<ForumTopic> GetAllByForumId(long forumId)
        {
            return _context.ForumTopics.Where(x => x.ForumId == forumId).ToList();
        }

        public List<ForumTopic> GetAllByUserId(int userId)
        {
            return _context.ForumTopics.Where(x => x.TopicPoster == userId).ToList();
        }

        public void Add(ForumTopic forumTopic)
        {
            _context.ForumTopics.Add(forumTopic);
            _context.SaveChanges();
        }

        public void Edit(ForumTopic forumTopic)
        {
            if (forumTopic != null)
            {
                _context.SaveChanges();
            }
        }

        public void Delete(long id)
        {
            var topic = _context.ForumTopics.FirstOrDefault(x => x.TopicId == id);
            if (topic != null)
            {
                _context.ForumTopics.Remove(topic);
                _context.SaveChanges();
            }
        }
    }
}
