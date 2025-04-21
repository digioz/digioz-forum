using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumTopicService
    {
        ForumTopic Get(long id);
        List<ForumTopic> GetAll();
        List<ForumTopic> GetAllByForumId(long forumId);
        List<ForumTopic> GetAllByUserId(int userId);
        void Add(ForumTopic forumTopic);
        void Edit(ForumTopic forumTopic);
        void Delete(long id);
    }
}
