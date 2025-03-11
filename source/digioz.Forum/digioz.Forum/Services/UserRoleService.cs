using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace digioz.Forum.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRoleService(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public AspNetRole Get(string id)
        {
            var role = _roleManager.FindByIdAsync(id).Result;
            return new AspNetRole
            {
                Id = role.Id,
                Name = role.Name,
                NormalizedName = role.NormalizedName,
                ConcurrencyStamp = role.ConcurrencyStamp
            };
        }

        public List<AspNetRole> GetAll()
        {
            return _roleManager.Roles.Select(role => new AspNetRole
            {
                Id = role.Id,
                Name = role.Name,
                NormalizedName = role.NormalizedName,
                ConcurrencyStamp = role.ConcurrencyStamp
            }).ToList();
        }

        public Dictionary<string, string> GetAllDictionary()
        {
            return _roleManager.Roles.ToDictionary(role => role.Id, role => role.Name);
        }

        public void Add(AspNetRole role)
        {
            var identityRole = new IdentityRole
            {
                Id = role.Id,
                Name = role.Name,
                NormalizedName = role.NormalizedName,
                ConcurrencyStamp = role.ConcurrencyStamp
            };
            _roleManager.CreateAsync(identityRole).Wait();
        }

        public void Edit(AspNetRole role)
        {
            var identityRole = _roleManager.FindByIdAsync(role.Id).Result;
            if (identityRole != null)
            {
                identityRole.Name = role.Name;
                identityRole.NormalizedName = role.NormalizedName;
                identityRole.ConcurrencyStamp = role.ConcurrencyStamp;
                _roleManager.UpdateAsync(identityRole).Wait();
            }
        }

        public void Delete(string id)
        {
            var role = _roleManager.FindByIdAsync(id).Result;
            if (role != null)
            {
                _roleManager.DeleteAsync(role).Wait();
            }
        }

        public int Count()
        {
            return _roleManager.Roles.Count();
        }
    }
}
