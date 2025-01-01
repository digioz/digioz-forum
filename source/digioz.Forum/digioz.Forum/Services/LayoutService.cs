using digioz.Forum.Models;
using digioz.Forum.Models.ViewModels;
using digioz.Forum.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace digioz.Forum.Services
{
    public class LayoutService : ILayoutService
    {
        private DigiozForumContext _context;
        private readonly LayoutViewModel _cachedData;

        public LayoutService()
        {
            _context = new DigiozForumContext();
            _cachedData = GetLayoutDataFromDb();
        }

        public LayoutViewModel GetLayoutData()
        {
            return _cachedData;
        }

        private LayoutViewModel GetLayoutDataFromDb()
        {
            var layoutData = new LayoutViewModel();

            // Load active Forum Style
            var forumStyle = _context.ForumStyles.Where(x => x.StyleActive == 1).SingleOrDefault();
            layoutData.ForumStyle = forumStyle;

            // Load configuration data
            var forumConfig = _context.ForumConfigs.ToList();
            layoutData.ForumConfig = forumConfig.ToDictionary(x => x.ConfigName, x => x.ConfigValue);

            return layoutData;
        }
    }
}
