using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumConfigService
    {
        ForumConfig Get(string configName);
        List<ForumConfig> GetAll();
        void Add(ForumConfig forumConfig);
        void Update(ForumConfig forumConfig);
        void Delete(string configName);
        int Count();
    }
}
