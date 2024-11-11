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

            migrationBuilder.CreateTable(
                name: "ForumBookmark",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumBookmark", x => new { x.TopicId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "ForumBot",
                columns: table => new
                {
                    BotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BotActive = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    BotName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BotAgent = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    BotIp = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumBot", x => x.BotId);
                });

            migrationBuilder.CreateTable(
                name: "ForumConfig",
                columns: table => new
                {
                    ConfigName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ConfigValue = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    IsDynamic = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumConfig", x => x.ConfigName);
                });

            migrationBuilder.CreateTable(
                name: "ForumConfigText",
                columns: table => new
                {
                    ConfigName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ConfigValue = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumConfigText", x => x.ConfigName);
                });

            migrationBuilder.CreateTable(
                name: "ForumConfirm",
                columns: table => new
                {
                    ConfirmId = table.Column<string>(type: "char(32)", nullable: false, defaultValue: ""),
                    SessionId = table.Column<string>(type: "char(32)", nullable: false, defaultValue: ""),
                    ConfirmType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    Code = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    Seed = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Attempts = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumConfirm", x => new { x.SessionId, x.ConfirmId });
                });

            migrationBuilder.CreateTable(
                name: "ForumDisallow",
                columns: table => new
                {
                    DisallowId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisallowUsername = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumDisallow", x => x.DisallowId);
                });

            migrationBuilder.CreateTable(
                name: "ForumDrafts",
                columns: table => new
                {
                    DraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    SaveTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DraftSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    DraftMessage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumDrafts", x => x.DraftId);
                });

            migrationBuilder.CreateTable(
                name: "ForumExt",
                columns: table => new
                {
                    ExtName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ExtActive = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ExtState = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumExt", x => x.ExtName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumExt_ExtName",
                table: "ForumExt",
                column: "ExtName",
                unique: true);

            migrationBuilder.CreateTable(
                name: "ForumExtension",
                columns: table => new
                {
                    ExtensionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    Extension = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumExtension", x => x.ExtensionId);
                });

            migrationBuilder.CreateTable(
                name: "ForumExtensionGroup",
                columns: table => new
                {
                    GroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    CatId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    AllowGroup = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    DownloadMode = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UploadIcon = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    MaxFileSize = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    AllowedForums = table.Column<string>(type: "text", nullable: false),
                    AllowInPm = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumExtensionGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "ForumGroup",
                columns: table => new
                {
                    GroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    GroupFounderManage = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    GroupSkipAuth = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    GroupName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    GroupDesc = table.Column<string>(type: "text", nullable: false),
                    GroupDescBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    GroupDescOptions = table.Column<int>(type: "int", nullable: false, defaultValue: 7),
                    GroupDescUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    GroupDisplay = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    GroupAvatar = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    GroupAvatarType = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    GroupAvatarWidth = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    GroupAvatarHeight = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    GroupRank = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    GroupColour = table.Column<string>(type: "varchar(6)", nullable: false, defaultValue: ""),
                    GroupSigChars = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    GroupReceivePm = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    GroupMessageLimit = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    GroupLegend = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    GroupMaxRecipients = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "ForumIcon",
                columns: table => new
                {
                    IconsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconsUrl = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    IconsWidth = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    IconsHeight = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    IconsAlt = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    IconsOrder = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    DisplayOnPosting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumIcon", x => x.IconsId);
                });

            migrationBuilder.CreateTable(
                name: "ForumLang",
                columns: table => new
                {
                    LangId = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangIso = table.Column<string>(type: "varchar(30)", nullable: false, defaultValue: ""),
                    LangDir = table.Column<string>(type: "varchar(30)", nullable: false, defaultValue: ""),
                    LangEnglishName = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    LangLocalName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    LangAuthor = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumLang", x => x.LangId);
                });

            migrationBuilder.CreateTable(
                name: "ForumLog",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ReporteeId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LogIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    LogTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LogOperation = table.Column<string>(type: "text", nullable: false),
                    LogData = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumLog", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "ForumLoginAttempt",
                columns: table => new
                {
                    AttemptIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    AttemptBrowser = table.Column<string>(type: "varchar(150)", nullable: false, defaultValue: ""),
                    AttemptForwardedFor = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    AttemptTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Username = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UsernameClean = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                });

            migrationBuilder.CreateTable(
                name: "ForumMigration",
                columns: table => new
                {
                    MigrationName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    MigrationDependsOn = table.Column<string>(type: "text", nullable: false),
                    MigrationSchemaDone = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    MigrationDataDone = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    MigrationDataState = table.Column<string>(type: "text", nullable: false),
                    MigrationStartTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MigrationEndTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumMigration", x => x.MigrationName);
                });

            migrationBuilder.CreateTable(
                name: "ForumModeratorCache",
                columns: table => new
                {
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Username = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    GroupId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    GroupName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    DisplayOnIndex = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumModeratorCache", x => new { x.ForumId, x.UserId, x.GroupId });
                });

            migrationBuilder.CreateTable(
                name: "ForumModule",
                columns: table => new
                {
                    ModuleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleEnabled = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    ModuleDisplay = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    ModuleBasename = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ModuleClass = table.Column<string>(type: "varchar(10)", nullable: false, defaultValue: ""),
                    ParentId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LeftId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RightId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ModuleLangname = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ModuleMode = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ModuleAuth = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumModule", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "ForumNotification",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeId = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    ItemId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ItemParentId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    NotificationRead = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    NotificationTime = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    NotificationData = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumNotification", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "ForumNotificationEmail",
                columns: table => new
                {
                    NotificationTypeId = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    ItemId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ItemParentId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumNotificationEmail", x => new { x.NotificationTypeId, x.ItemId, x.ItemParentId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "ForumNotificationType",
                columns: table => new
                {
                    NotificationTypeId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    NotificationTypeEnabled = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumNotificationType", x => x.NotificationTypeId);
                });

                migrationBuilder.CreateIndex(
                    name: "IX_ForumNotificationType_NotificationTypeName",
                    table: "ForumNotificationType",
                    column: "NotificationTypeName",
                    unique: true);

            migrationBuilder.CreateTable(
                name: "ForumOauthAccount",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Provider = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    OauthProviderId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumOauthAccount", x => new { x.UserId, x.Provider });
                });

            migrationBuilder.CreateTable(
                name: "ForumOauthState",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SessionId = table.Column<string>(type: "char(32)", nullable: false, defaultValue: ""),
                    Provider = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    OauthState = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumOauthState", x => new { x.UserId, x.SessionId, x.Provider });
                });

            migrationBuilder.CreateTable(
                name: "ForumOauthToken",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SessionId = table.Column<string>(type: "char(32)", nullable: false, defaultValue: ""),
                    Provider = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    OauthToken = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumOauthToken", x => new { x.UserId, x.SessionId, x.Provider });
                });

            migrationBuilder.CreateTable(
                name: "ForumPollOption",
                columns: table => new
                {
                    PollOptionId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PollOptionText = table.Column<string>(type: "text", nullable: false),
                    PollOptionTotal = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPollOption", x => new { x.PollOptionId, x.TopicId });
                });

            migrationBuilder.CreateTable(
                name: "ForumPollVote",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PollOptionId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    VoteUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    VoteUserIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPollVote", x => new { x.TopicId, x.PollOptionId, x.VoteUserId });
                });

            migrationBuilder.CreateTable(
                name: "ForumPost",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IconId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PosterIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    PostTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostReported = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    EnableBbcode = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableSmilies = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableMagicUrl = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableSig = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PostUsername = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostText = table.Column<string>(type: "text", nullable: false),
                    PostChecksum = table.Column<string>(type: "varchar(32)", nullable: false, defaultValue: ""),
                    PostAttachment = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    BbcodeBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    BbcodeUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    PostCount = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PostEditTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostEditReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostEditUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostEditCount = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    PostEditLocked = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PostVisibility = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PostDeleteTime = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostDeleteReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostDeleteUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPost", x => x.PostId);
                });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(name: "ForumPost");
            migrationBuilder.DropTable(name: "ForumPollVote");
            migrationBuilder.DropTable(name: "ForumPollOption");
            migrationBuilder.DropTable(name: "ForumOauthToken");
            migrationBuilder.DropTable(name: "ForumOauthState");
            migrationBuilder.DropTable(name: "ForumOauthAccount");
            migrationBuilder.DropTable(name: "ForumNotificationType");
            migrationBuilder.DropTable(name: "ForumNotificationEmail");
            migrationBuilder.DropTable(name: "ForumNotification");
            migrationBuilder.DropTable(name: "ForumModule");
            migrationBuilder.DropTable(name: "ForumModeratorCache");
            migrationBuilder.DropTable(name: "ForumMigration");
            migrationBuilder.DropTable(name: "ForumLoginAttempt");
            migrationBuilder.DropTable(name: "ForumLog");
            migrationBuilder.DropTable(name: "ForumLang");
            migrationBuilder.DropTable(name: "ForumIcon");
            migrationBuilder.DropTable(name: "ForumGroup");
            migrationBuilder.DropTable(name: "ForumExtensionGroup");
            migrationBuilder.DropTable(name: "ForumExtension");
            migrationBuilder.DropTable(name: "ForumExt");
            migrationBuilder.DropTable(name: "ForumDrafts");
            migrationBuilder.DropTable(name: "ForumDisallow");
            migrationBuilder.DropTable(name: "ForumConfirm");
            migrationBuilder.DropTable(name: "ForumConfigText");
            migrationBuilder.DropTable(name: "ForumConfig");
            migrationBuilder.DropTable(name: "ForumBot");
            migrationBuilder.DropTable(name: "ForumBookmark");
            migrationBuilder.DropTable(name: "ForumBbcode");
            migrationBuilder.DropTable(name: "ForumBanlist");
            migrationBuilder.DropTable(name: "ForumAttachment");
            migrationBuilder.DropTable(name: "ForumAclUser");
            migrationBuilder.DropTable(name: "ForumAclRoleData");
            migrationBuilder.DropTable(name: "ForumAclRole");
            migrationBuilder.DropTable(name: "ForumAclOption");
            migrationBuilder.DropTable(name: "ForumAclGroup");
            migrationBuilder.DropTable(name: "ForumAccess");
            migrationBuilder.DropTable(name: "Forum");
        }
    }
}
