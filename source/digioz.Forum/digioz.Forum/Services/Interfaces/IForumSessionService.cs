using digioz.Forum.Models;

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
    }
}
