using digioz.Forum.Models;
using digioz.Forum.Models.ViewModels;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumSessionService
    {
        ForumSession Get(string id);
        int GetForumUserId(string aspNetUserId);
        IEnumerable<ForumSession> GetAll();
        void Add(ForumSession session);
        void Edit(ForumSession session);
        void Delete(int id);
        WhoIsOnlineViewModel GetWhoIsOnline(int duration);
        StatisticsViewModel GetStatistics();
    }
}
