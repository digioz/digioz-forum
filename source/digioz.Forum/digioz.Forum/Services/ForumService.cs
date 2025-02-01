using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.Build.Framework;

namespace digioz.Forum.Services
{
    public class ForumService : IForumService
    {
        private DigiozForumContext _context;

        public ForumService(DigiozForumContext context)
        {
            _context = context;
        }

        public Models.Forum Get(int id)
        {
            var model = _context.Forums.Where(x => x.ForumId == id).SingleOrDefault();
            return model;
        }

        public List<Models.Forum> GetAll()
        {
            var models = _context.Forums.ToList();
            return models;
        }

        public void Add(Models.Forum forum)
        {
            _context.Forums.Add(forum);
            _context.SaveChanges();
        }

        public void Edit(Models.Forum forum)
        {
            var model = _context.Forums.Find(forum.ForumId);
            if (model != null)
            {
                _context.Forums.Update(forum);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var model = _context.Forums.Find(id);
            if (model != null)
            {
                _context.Forums.Remove(model);
                _context.SaveChanges();
            }
        }

        public int Count()
        {
            return _context.Forums.Count();
        }

        public List<long> GetForumIds()
        {
            var models = _context.Forums.Select(x => x.ForumId).ToList();
            return models;
        }
    }
}
