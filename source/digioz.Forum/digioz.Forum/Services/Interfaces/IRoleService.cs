using digioz.Forum.Models;

namespace digioz.Forum.Services.Interfaces
{
    public interface IRoleService
    {
        AspNetRole Get(string id);
        List<AspNetRole> GetAll();
        Dictionary<string, string> GetAllDictionary();
        void Add(AspNetRole role);
        void Edit(AspNetRole role);
        void Delete(string id);
        int Count(); 
    }
}
