using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;


namespace digioz.Forum.Services
{
    public class RoleService : IRoleService
    {
        private DigiozForumContext _context;

        public RoleService(DigiozForumContext context)
        {
            _context = context;
        }

        public AspNetRole Get(string id)
        {
            var model = _context.AspNetRoles.Find(id);
            return model;
        }

        public List<AspNetRole> GetAll()
        {
            var models = _context.AspNetRoles;
            return models.ToList();
        }

        public Dictionary<string, string> GetAllDictionary()
        {
            var models = _context.AspNetRoles;
            var modelDictionary = new Dictionary<string, string>();
            foreach (var model in models)
            {
                modelDictionary.Add(model.Id, model.Name);
            }
            return modelDictionary;
        }

        public void Add(AspNetRole role)
        {
            _context.AspNetRoles.Add(role);
            _context.SaveChanges();
        }

        public void Edit(AspNetRole role)
        {
            var model = _context.AspNetRoles.Find(role.Id);
            if (model != null)
            {
                _context.AspNetRoles.Update(role);
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var model = _context.AspNetRoles.Find(id);
            if (model != null)
            {
                _context.AspNetRoles.Remove(model);
                _context.SaveChanges();
            }
        }

        public int Count()
        {
            return _context.AspNetRoles.Count();
        }
    }
}
