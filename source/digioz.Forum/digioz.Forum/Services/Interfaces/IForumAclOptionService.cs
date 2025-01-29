using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumAclOptionService
    {
        ForumAclOption Get(int id);
        List<ForumAclOption> GetAll();
        void Add(ForumAclOption forumAclOption);
        void Edit(ForumAclOption forumAclOption);
        void Delete(int id);
        int Count();
    }
}
