using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.Build.Framework;

namespace digioz.Forum.Services
{
    public class ForumAclOptionService : IForumAclOptionService
    {
        private DigiozForumContext _context;
        public ForumAclOptionService(DigiozForumContext context)
        {
            _context = context;
        }
        public ForumAclOption Get(int id)
        {
            var model = _context.ForumAclOptions.Where(x => x.AuthOptionId == id).SingleOrDefault();
            return model;
        }
        public List<ForumAclOption> GetAll()
        {
            var models = _context.ForumAclOptions.ToList();
            return models;
        }
        public void Add(ForumAclOption forumAclOption)
        {
            _context.ForumAclOptions.Add(forumAclOption);
            _context.SaveChanges();
        }
        public void Edit(ForumAclOption forumAclOption)
        {
            var model = _context.ForumAclOptions.Find(forumAclOption.AuthOptionId);
            if (model != null)
            {
                _context.ForumAclOptions.Update(forumAclOption);
                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var model = _context.ForumAclOptions.Find(id);
            if (model != null)
            {
                _context.ForumAclOptions.Remove(model);
                _context.SaveChanges();
            }
        }
        public int Count()
        {
            return _context.ForumAclOptions.Count();
        }
    }
}
