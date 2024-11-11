using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forum",
                columns: table => new
                {
                    ForumId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LeftId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RightId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumParents = table.Column<string>(type: "text", nullable: false),
                    ForumName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumDesc = table.Column<string>(type: "text", nullable: false),
                    ForumDescBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumDescOptions = table.Column<int>(type: "int", nullable: false, defaultValue: 7),
                    ForumDescUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    ForumLink = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumPassword = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumStyle = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumImage = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumRules = table.Column<string>(type: "text", nullable: false),
                    ForumRulesLink = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumRulesBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumRulesOptions = table.Column<int>(type: "int", nullable: false, defaultValue: 7),
                    ForumRulesUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    ForumTopicsPerPage = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    ForumType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ForumStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ForumLastPostId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumLastPosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumLastPostSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumLastPostTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumLastPosterName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumLastPosterColour = table.Column<string>(type: "varchar(6)", nullable: false, defaultValue: ""),
                    ForumFlags = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 32),
                    DisplayOnIndex = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableIndexing = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableIcons = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnablePrune = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PruneNext = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PruneDays = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PruneViewed = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PruneFreq = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    DisplaySubforumList = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    DisplaySubforumLimit = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ForumOptions = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    EnableShadowPrune = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PruneShadowDays = table.Column<long>(type: "bigint", nullable: false, defaultValue: 7),
                    PruneShadowFreq = table.Column<long>(type: "bigint", nullable: false, defaultValue: 1),
                    PruneShadowNext = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumPostsApproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumPostsUnapproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumPostsSoftDeleted = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumTopicsApproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumTopicsUnapproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumTopicsSoftDeleted = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forum", x => x.ForumId);
                });

            migrationBuilder.CreateTable(
                name: "ForumAccess",
                columns: table => new
                {
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SessionId = table.Column<string>(type: "char(32)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAccess", x => new { x.ForumId, x.UserId, x.SessionId });
                });

            migrationBuilder.CreateTable(
                name: "ForumAclGroup",
                columns: table => new
                {
                    GroupId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthOptionId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthRoleId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthSetting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAclGroup", x => new { x.GroupId, x.ForumId, x.AuthOptionId, x.AuthRoleId });
                });

            migrationBuilder.CreateTable(
                name: "ForumAclOption",
                columns: table => new
                {
                    AuthOptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthOption = table.Column<string>(type: "varchar(50)", nullable: false, defaultValue: ""),
                    IsGlobal = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    IsLocal = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FounderOnly = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAclOption", x => x.AuthOptionId);
                });

                migrationBuilder.CreateIndex(
                    name: "IX_ForumAclOption_AuthOption",
                    table: "ForumAclOption",
                    column: "AuthOption",
                    unique: true);

            migrationBuilder.CreateTable(
                name: "ForumAclRole",
                columns: table => new
                {
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    RoleDescription = table.Column<string>(type: "text", nullable: false),
                    RoleType = table.Column<string>(type: "varchar(10)", nullable: false, defaultValue: ""),
                    RoleOrder = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAclRole", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ForumAclRoleData",
                columns: table => new
                {
                    RoleId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthOptionId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthSetting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAclRoleData", x => new { x.RoleId, x.AuthOptionId });
                });

            migrationBuilder.CreateTable(
                name: "ForumAclUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthOptionId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthRoleId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthSetting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAclUser", x => new { x.UserId, x.ForumId, x.AuthOptionId, x.AuthRoleId });
                });

            migrationBuilder.CreateTable(
                name: "ForumAttachment",
                columns: table => new
                {
                    AttachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostMsgId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    InMessage = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsOrphan = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PhysicalFilename = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    RealFilename = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    DownloadCount = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AttachComment = table.Column<string>(type: "text", nullable: false),
                    Extension = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    MimeType = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    FileSize = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FileTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Thumbnail = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAttachment", x => x.AttachId);
                });

            migrationBuilder.CreateTable(
                name: "ForumBanlist",
                columns: table => new
                {
                    BanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BanUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BanIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    BanEmail = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    BanStart = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BanEnd = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BanExclude = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    BanReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    BanGiveReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumBanlist", x => x.BanId);
                });

            migrationBuilder.CreateTable(
                name: "ForumBbcode",
                columns: table => new
                {
                    BbcodeId = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    BbcodeTag = table.Column<string>(type: "varchar(16)", nullable: false, defaultValue: ""),
                    BbcodeHelpline = table.Column<string>(type: "text", nullable: false),
                    DisplayOnPosting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    BbcodeMatch = table.Column<string>(type: "text", nullable: false),
                    BbcodeTpl = table.Column<string>(type: "text", nullable: false),
                    FirstPassMatch = table.Column<string>(type: "text", nullable: false),
                    FirstPassReplace = table.Column<string>(type: "text", nullable: false),
                    SecondPassMatch = table.Column<string>(type: "text", nullable: false),
                    SecondPassReplace = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumBbcode", x => x.BbcodeId);
                });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
            name: "ForumBbcode");
            migrationBuilder.DropTable(
            name: "ForumBanlist");
            migrationBuilder.DropTable(
            name: "ForumAttachment");
            migrationBuilder.DropTable(
            name: "ForumAclUser");
            migrationBuilder.DropTable(
            name: "ForumAclRoleData");
            migrationBuilder.DropTable(
            name: "ForumAclRole");
            migrationBuilder.DropTable(
            name: "ForumAclOption");
            migrationBuilder.DropTable(
            name: "ForumAclGroup");
            migrationBuilder.DropTable(
            name: "ForumAccess");
            migrationBuilder.DropTable(
            name: "Forum");
        }
    }
}
