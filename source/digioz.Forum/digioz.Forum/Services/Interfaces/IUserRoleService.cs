using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IUserRoleService
    {
        AspNetRole Get(string userId, string id);
        List<AspNetRole> GetAll(string userId);
        Dictionary<string, string> GetAllDictionary(string userId);
        void Add(AspNetRole role, string userId);
        void Delete(string userId, string id);
        int Count(string userId);
    }
}
