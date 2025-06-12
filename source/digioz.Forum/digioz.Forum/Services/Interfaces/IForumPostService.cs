using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumPostService
    {
        ForumPost Get(int id);
        List<ForumPost> GetAll();
        List<ForumPost> GetAllByForumId(long forumId);
        List<ForumPost> GetAllByUserId(int userId);
        List<ForumPost> GetAllByTopicId(int topicId);
        void Add(ForumPost forumPost);
        void Edit(ForumPost forumPost);
        void Delete(int id);
    }
}
