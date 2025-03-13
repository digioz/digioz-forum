using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace digioz.Forum.Services
{
    public class ForumConfigService : IForumConfigService
    {
        private DigiozForumContext _context;

        public ForumConfigService(DigiozForumContext context)
        {
            _context = context;
        }

        public ForumConfig Get(string configName)
        {
            var model = _context.ForumConfigs.Find(configName);

            return model;
        }

        public List<ForumConfig> GetAll()
        {
            var models = _context.ForumConfigs.ToList();

            return models;
        }

        public void Add(ForumConfig forumConfig)
        {
            _context.ForumConfigs.Add(forumConfig);
            _context.SaveChanges();
        }

        public void Update(ForumConfig forumConfig)
        {
            var model = _context.ForumConfigs.Find(forumConfig.ConfigName);

            if (model != null)
            {
                _context.Entry(model).State = EntityState.Detached;
                _context.ForumConfigs.Update(forumConfig);
                _context.SaveChanges();
            }
        }

        public void Delete(string configName)
        {
            var model = _context.ForumConfigs.Find(configName);

            if (model != null)
            {
                _context.ForumConfigs.Remove(model);
                _context.SaveChanges();
            }
        }

        public int Count()
        {
            return _context.ForumConfigs.Count();
        }

    }
}
