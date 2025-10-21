using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;

namespace digioz.Forum.Services
{
    public class ForumLogService : IForumLogService
    {
        private readonly DigiozForumContext _context;
        public ForumLogService(DigiozForumContext context)
        {
            _context = context;
        }

        public void Add(ForumLog log)
        {
            _context.ForumLogs.Add(log);
            _context.SaveChanges();
        }
    }
}
