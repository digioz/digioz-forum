using Microsoft.Identity.Client;

namespace digioz.Forum.Models.ViewModels
{
    public class StatisticsViewModel
    {
        public int TotalPosts { get; set; }
        public int TotalTopics { get; set; }
        public int TotalMembers { get; set; }
        public ForumUser NewestMember { get; set; }
    }
}
