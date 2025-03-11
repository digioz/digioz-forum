using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IForumService
    {
        Models.Forum Get(int id);
        List<Models.Forum> GetAll();
        List<Models.Forum> GetAllByRoleId(string roleId);
        void Add(Models.Forum forum);
        void Edit(Models.Forum forum);
        void Delete(int id);
        int Count();
        List<long> GetForumIds();
    }
}
