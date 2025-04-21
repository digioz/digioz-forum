using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;

namespace digioz.Forum.Services
{
    public class ForumPermissionService : IForumPermissionService
    {
        private DigiozForumContext _context;

        public ForumPermissionService(DigiozForumContext context)
        {
            _context = context;
        }

        public void Add(ForumPermission forumPermission)
        {
            _context.ForumPermissions.Add(forumPermission);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = _context.ForumPermissions.Find(id);
            if (model != null)
            {
                _context.ForumPermissions.Remove(model);
                _context.SaveChanges();
            }
        }

        public void Edit(ForumPermission forumPermission)
        {
            var model = _context.ForumPermissions.Find(forumPermission.ForumPermissionId);
            if (model != null)
            {
                _context.ForumPermissions.Update(forumPermission);
                _context.SaveChanges();
            }
        }

        public ForumPermission Get(int id)
        {
            return _context.ForumPermissions.Find(id);
        }

        public List<ForumPermission> GetAll()
        {
            var models = _context.ForumPermissions.ToList();
            return models;
        }

        public List<ForumPermission> GetAllByRoleId(string roleId)
        {
            var forumIds = _context.ForumPermissions.Where(x => x.RoleId == roleId).Select(x => x.ForumId).ToList();
            var models = _context.ForumPermissions.Where(x => forumIds.Contains(x.ForumId)).ToList();
            return models;
        }
    }
}
