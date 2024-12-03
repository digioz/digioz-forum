namespace digioz.Forum.Models.ViewModels
{
    public class LayoutViewModel
    {
        public string UserId { get; set; }
        public int ForumUserId { get; set; }
        public string ForumUsername { get; set; }
        public ForumStyle ForumStyle { get; set; }
        public Dictionary<string, string> ForumConfig { get; set; }

    }
}
