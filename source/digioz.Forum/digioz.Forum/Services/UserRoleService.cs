using digioz.Forum.Models;
using digioz.Forum.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using SQLitePCL;

namespace digioz.Forum.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private DigiozForumContext _context;

        public UserRoleService(DigiozForumContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public AspNetRole Get(string userId, string id)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                var roles = _userManager.GetRolesAsync(user).Result;
                if (roles.Any(roleName => _roleManager.Roles.Any(r => r.Id == id && r.Name == roleName)))
                {
                    return null;
                }
            }

            var role = _roleManager.FindByIdAsync(userId).Result;
            if (role == null)
            {
                return null;
            }

            return new AspNetRole
            {
                Id = role.Id,
                Name = role.Name,
                NormalizedName = role.NormalizedName,
                ConcurrencyStamp = role.ConcurrencyStamp
            };
        }

        public List<AspNetRole> GetAll(string userId)
        {
            return _roleManager.Roles
                .Where(role => _userManager.IsInRoleAsync(_userManager.FindByIdAsync(userId).Result, role.Name).Result)
                .Select(role => new AspNetRole
                {
                    Id = role.Id,
                    Name = role.Name,
                    NormalizedName = role.NormalizedName,
                    ConcurrencyStamp = role.ConcurrencyStamp
                }).ToList();
        }

        public Dictionary<string, string> GetAllDictionary(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user == null)
            {
                return new Dictionary<string, string>();
            }

            var userRoles = _userManager.GetRolesAsync(user).Result;
            var roleDictionary = _roleManager.Roles
                .Where(role => userRoles.Contains(role.Name))
                .ToDictionary(role => role.Id, role => role.Name);

            return roleDictionary;
        }

        public void Add(AspNetRole role, string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                var result = _userManager.AddToRoleAsync(user, role.Name).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }

        public void Delete(string id, string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                var result = _userManager.RemoveFromRoleAsync(user, id).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }

        public int Count(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                var roles = _userManager.GetRolesAsync(user).Result;
                return roles.Count();
            }
            else
            {
                return 0;
            }
        }
    }
}
