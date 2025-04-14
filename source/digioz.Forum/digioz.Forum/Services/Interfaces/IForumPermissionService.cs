using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumPermissionService
    {
        ForumPermission Get(int id);
        List<ForumPermission> GetAll();
        List<ForumPermission> GetAllByRoleId(string roleId);
        void Add(ForumPermission forumPermission);
        void Edit(ForumPermission forumPermission);
        void Delete(int id);
    }
}
