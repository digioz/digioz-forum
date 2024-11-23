using digioz.Forum.Models;

namespace digioz.Forum.Helpers
{
    public class ConfigHelper
    {
        private DigiozForumContext _context;

        public ConfigHelper()
        {
            _context = new DigiozForumContext();
        }

        public Dictionary<string, string> GetForumConfigs()
        {
            var configs = _context.ForumConfigs.ToDictionary(x => x.ConfigName, x => x.ConfigValue);
            return configs;
        }

        public List<ForumStyle> GetForumStyles() {
            var styles = _context.ForumStyles.ToList();
            return styles;
        }
    }
}
