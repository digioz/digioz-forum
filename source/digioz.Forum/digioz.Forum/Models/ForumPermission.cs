namespace digioz.Forum.Models
{
    public partial class ForumPermission
    {
        public long ForumPermissionId { get; set; }
        public long ForumId { get; set; }
        public string RoleId { get; set; } = null!;
        public bool IsReadOnly { get; set; }
    }
}
