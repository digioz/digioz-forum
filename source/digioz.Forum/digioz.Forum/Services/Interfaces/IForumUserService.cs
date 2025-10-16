using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumUserService
    {
        ForumUser Get(int id);
        List<ForumUser> GetAll();
        void Add(ForumUser ForumUser);
        void Edit(ForumUser ForumUser);
        void Delete(int id);
        bool DoesUserExist(string userId);
        bool DoesForumUserExist(int forumUserId);
        bool DoesForumUsernameExist(string username);
        string GetEmailByUserName(string username);
        ForumUser GetByUserId(int userId);
        List<ForumUser> GetByPosts(List<ForumPost> posts);
    }
}
