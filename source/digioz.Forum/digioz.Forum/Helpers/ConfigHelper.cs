using digioz.Forum.Models;

namespace digioz.Forum.Helpers
{
    public class ConfigHelper
    {
        public Dictionary<string, string> GetForumConfigs()
        {
            using var context = new DigiozForumContext();
            var configs = context.ForumConfigs.ToDictionary(x => x.ConfigName, x => x.ConfigValue);
            return configs;           
        }

        public List<ForumStyle> GetForumStyles() 
        {
            using var _context = new DigiozForumContext();
            var styles = _context.ForumStyles.ToList();
            return styles;
        }
    }
}
