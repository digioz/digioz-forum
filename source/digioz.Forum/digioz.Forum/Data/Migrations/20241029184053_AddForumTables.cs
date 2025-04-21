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
                    ForumLastPostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumLastPosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumLastPostSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ForumLastPostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "ForumAttachment",
                columns: table => new
                {
                    AttachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostMsgId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
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
                    FileTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    BanStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BanEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
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
                name: "ForumDraft",
                columns: table => new
                {
                    DraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    SaveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ReporteeId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LogIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    AttemptTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Username = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UsernameClean = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
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
                name: "ForumPollOption",
                columns: table => new
                {
                    PollOptionId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
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
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
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
                    PostId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IconId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PosterIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    PostEditTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostEditReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostEditUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostEditCount = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    PostEditLocked = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PostVisibility = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PostDeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostDeleteReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PostDeleteUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPost", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "ForumPrivmsg",
                columns: table => new
                {
                    MsgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootLevel = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthorId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IconId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    AuthorIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    MessageTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnableBbcode = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableSmilies = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableMagicUrl = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    EnableSig = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    MessageSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    MessageText = table.Column<string>(type: "text", nullable: false),
                    MessageEditReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    MessageEditUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MessageAttachment = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    BbcodeBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    BbcodeUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    MessageEditTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MessageEditCount = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    ToAddress = table.Column<string>(type: "text", nullable: false),
                    BccAddress = table.Column<string>(type: "text", nullable: false),
                    MessageReported = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPrivmsg", x => x.MsgId);
                });

            migrationBuilder.CreateTable(
                name: "ForumPrivmsgsFolder",
                columns: table => new
                {
                    FolderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FolderName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PmCount = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPrivmsgsFolder", x => x.FolderId);
                });

            migrationBuilder.CreateTable(
                name: "ForumPrivmsgsRule",
                columns: table => new
                {
                    RuleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RuleCheck = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RuleConnection = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RuleString = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    RuleUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RuleGroupId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RuleAction = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    RuleFolderId = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPrivmsgsRule", x => x.RuleId);
                });

            migrationBuilder.CreateTable(
                name: "ForumPrivmsgsTo",
                columns: table => new
                {
                    MsgId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    AuthorId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PmDeleted = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PmNew = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PmUnread = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PmReplied = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PmMarked = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    PmForwarded = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FolderId = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPrivmsgsTo", x => new { x.MsgId, x.UserId, x.AuthorId });
                });

            migrationBuilder.CreateTable(
                name: "ForumProfileField",
                columns: table => new
                {
                    FieldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldType = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    FieldIdent = table.Column<string>(type: "varchar(20)", nullable: false, defaultValue: ""),
                    FieldLength = table.Column<string>(type: "varchar(20)", nullable: false, defaultValue: ""),
                    FieldMinlen = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldMaxlen = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldNovalue = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldDefaultValue = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldValidation = table.Column<string>(type: "varchar(128)", nullable: false, defaultValue: ""),
                    FieldRequired = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldShowOnReg = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldHide = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldNoView = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldActive = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldOrder = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    FieldShowProfile = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldShowOnVt = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldShowNovalue = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldShowOnPm = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldShowOnMl = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldIsContact = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    FieldContactDesc = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    FieldContactUrl = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumProfileField", x => x.FieldId);
                });

            migrationBuilder.CreateTable(
                name: "ForumProfileFieldsData",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PfForumInterests = table.Column<string>(type: "text", nullable: false),
                    PfForumOccupation = table.Column<string>(type: "text", nullable: false),
                    PfForumLocation = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumSkype = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumFacebook = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumIcq = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumTwitter = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumWebsite = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumYoutube = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PfForumYahoo = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumProfileFieldsData", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ForumProfileFieldsLang",
                columns: table => new
                {
                    FieldId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LangId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    OptionId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    FieldType = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    LangValue = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumProfileFieldsLang", x => new { x.FieldId, x.LangId, x.OptionId });
                });

            migrationBuilder.CreateTable(
                name: "ForumProfileLang",
                columns: table => new
                {
                    FieldId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LangId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LangName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    LangExplain = table.Column<string>(type: "text", nullable: false),
                    LangDefaultValue = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumProfileLang", x => new { x.FieldId, x.LangId });
                });

            migrationBuilder.CreateTable(
                name: "ForumReport",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonId = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    PostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserNotify = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ReportClosed = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportText = table.Column<string>(type: "text", nullable: false),
                    PmId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ReportedPostEnableBbcode = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    ReportedPostEnableSmilies = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    ReportedPostEnableMagicUrl = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    ReportedPostText = table.Column<string>(type: "text", nullable: false),
                    ReportedPostUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    ReportedPostBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReport", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "ForumReportsReason",
                columns: table => new
                {
                    ReasonId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonTitle = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    ReasonDescription = table.Column<string>(type: "text", nullable: false),
                    ReasonOrder = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumReportsReason", x => x.ReasonId);
                });

            migrationBuilder.CreateTable(
                name: "ForumSession",
                columns: table => new
                {
                    SessionId = table.Column<string>(type: "varchar(128)", nullable: false, defaultValue: ""),
                    SessionUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SessionLastVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    SessionBrowser = table.Column<string>(type: "varchar(150)", nullable: false, defaultValue: ""),
                    SessionForwardedFor = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    SessionPage = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    SessionViewOnline = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    SessionAutoLogin = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    SessionAdmin = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    SessionForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumSession", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "ForumSmilie",
                columns: table => new
                {
                    SmileyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(50)", nullable: false, defaultValue: ""),
                    Emotion = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    SmileyUrl = table.Column<string>(type: "varchar(50)", nullable: false, defaultValue: ""),
                    SmileyWidth = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    SmileyHeight = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    SmileyOrder = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    DisplayOnPosting = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumSmilie", x => x.SmileyId);
                });

            migrationBuilder.CreateTable(
                name: "ForumStyle",
                columns: table => new
                {
                    StyleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    StyleCopyright = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    StyleActive = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    StylePath = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    BbcodeBitField = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "kNg="),
                    StyleParentId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    StyleParentTree = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumStyle", x => x.StyleId);
                    table.UniqueConstraint("AK_ForumStyle_StyleName", x => x.StyleName);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopic",
                columns: table => new
                {
                    TopicId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    IconId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicAttachment = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicReported = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicTitle = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    TopicPoster = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicTimeLimit = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicViews = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicFirstPostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicFirstPosterName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    TopicFirstPosterColor = table.Column<string>(type: "varchar(6)", nullable: false, defaultValue: ""),
                    TopicLastPostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicLastPosterId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicLastPosterName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    TopicLastPosterColor = table.Column<string>(type: "varchar(6)", nullable: false, defaultValue: ""),
                    TopicLastPostSubject = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    TopicLastPostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicLastViewTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicMovedId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicBumped = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicBumper = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    PollTitle = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    PollStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PollLength = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PollMaxOptions = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    PollLastVote = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PollVoteChange = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicVisibility = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    TopicDeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicDeleteReason = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    TopicDeleteUser = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicPostsApproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicPostsUnapproved = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicPostsSoftdeleted = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopic", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopicsPosted",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    TopicPosted = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopicsPosted", x => new { x.UserId, x.TopicId });
                });

            migrationBuilder.CreateTable(
                name: "ForumTopicsTrack",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    MarkTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopicsTrack", x => new { x.UserId, x.TopicId });
                });

            migrationBuilder.CreateTable(
                name: "ForumTopicsWatch",
                columns: table => new
                {
                    TopicId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    NotifyStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopicsWatch", x => new { x.TopicId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "ForumTrack",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ForumId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    MarkTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTrack", x => new { x.UserId, x.ForumId });
                });

            migrationBuilder.CreateTable(
                name: "ForumUser",
                columns: table => new
                {
                    ForumUserId = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "varchar(128)", nullable: false),
                    UserType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    GroupId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 3),
                    UserPermissions = table.Column<string>(type: "text", nullable: false),
                    UserPermFrom = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserIp = table.Column<string>(type: "varchar(40)", nullable: false, defaultValue: ""),
                    UserRegdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserNameClean = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserEmail = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    UserBirthday = table.Column<string>(type: "varchar(10)", nullable: false, defaultValue: ""),
                    UserLastVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserLastActive = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserLastMark = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserLastPostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserLastPage = table.Column<string>(type: "varchar(200)", nullable: false, defaultValue: ""),
                    UserLastConfirmKey = table.Column<string>(type: "varchar(10)", nullable: false, defaultValue: ""),
                    UserLastSearch = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserWarnings = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserLastWarning = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserLoginAttempts = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserInactiveReason = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserInactiveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserPosts = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserLang = table.Column<string>(type: "varchar(30)", nullable: false, defaultValue: ""),
                    UserTimeZone = table.Column<string>(type: "varchar(100)", nullable: false, defaultValue: ""),
                    UserDateFormat = table.Column<string>(type: "varchar(64)", nullable: false, defaultValue: "d M Y H:i"),
                    UserStyle = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserRank = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    UserColor = table.Column<string>(type: "varchar(6)", nullable: false, defaultValue: ""),
                    UserNewPrivmsg = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserUnreadPrivmsg = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserLastPrivmsg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserMessageRules = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserFullFolder = table.Column<int>(type: "int", nullable: false, defaultValue: -3),
                    UserEmailTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserTopicShowDays = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    UserTopicSortbyType = table.Column<string>(type: "varchar(1)", nullable: false, defaultValue: "t"),
                    UserTopicSortbyDir = table.Column<string>(type: "varchar(1)", nullable: false, defaultValue: "d"),
                    UserPostShowDays = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    UserPostSortbyType = table.Column<string>(type: "varchar(1)", nullable: false, defaultValue: "t"),
                    UserPostSortbyDir = table.Column<string>(type: "varchar(1)", nullable: false, defaultValue: "a"),
                    UserNotify = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserNotifyPm = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserNotifyType = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserAllowPm = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserAllowViewOnline = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserAllowViewEmail = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserAllowMassemail = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserOptions = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserAvatar = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserAvatarType = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserAvatarWidth = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    UserAvatarHeight = table.Column<short>(type: "smallint", nullable: false, defaultValue: 0),
                    UserSig = table.Column<string>(type: "text", nullable: false),
                    UserSigBbcodeUid = table.Column<string>(type: "varchar(8)", nullable: false, defaultValue: ""),
                    UserSigBbcodeBitfield = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserJabber = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserActkey = table.Column<string>(type: "varchar(32)", nullable: false, defaultValue: ""),
                    UserActkeyExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "varchar(64)", nullable: false, defaultValue: ""),
                    ResetTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserNewpasswd = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    UserFormSalt = table.Column<string>(type: "varchar(32)", nullable: false, defaultValue: ""),
                    UserNew = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 1),
                    UserReminded = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    UserRemindedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUser", x => x.ForumUserId);
                    table.UniqueConstraint("AK_ForumUser_UserNameClean", x => x.UserNameClean);
                });

            migrationBuilder.CreateTable(
                name: "ForumWarning",
                columns: table => new
                {
                    WarningId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostId = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0),
                    LogId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    WarningTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumWarning", x => x.WarningId);
                });

            migrationBuilder.CreateTable(
                name: "ForumWord",
                columns: table => new
                {
                    WordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: ""),
                    Replacement = table.Column<string>(type: "varchar(255)", nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumWord", x => x.WordId);
                });

            migrationBuilder.CreateTable(
                name: "ForumZebra",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ZebraId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Friend = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0),
                    Foe = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumZebra", x => new { x.UserId, x.ZebraId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ForumZebra");
            migrationBuilder.DropTable(name: "ForumWord");
            migrationBuilder.DropTable(name: "ForumWarning");
            migrationBuilder.DropTable(name: "ForumUser");
            migrationBuilder.DropTable(name: "ForumTrack");
            migrationBuilder.DropTable(name: "ForumTopicsWatch");
            migrationBuilder.DropTable(name: "ForumTopicsTrack");
            migrationBuilder.DropTable(name: "ForumTopicsPosted");
            migrationBuilder.DropTable(name: "ForumTopic");
            migrationBuilder.DropTable(name: "ForumStyle");
            migrationBuilder.DropTable(name: "ForumSmilie");
            migrationBuilder.DropTable(name: "ForumSession");
            migrationBuilder.DropTable(name: "ForumReportsReason");
            migrationBuilder.DropTable(name: "ForumReport");
            migrationBuilder.DropTable(name: "ForumProfileLang");
            migrationBuilder.DropTable(name: "ForumProfileFieldsLang");
            migrationBuilder.DropTable(name: "ForumProfileFieldsData");
            migrationBuilder.DropTable(name: "ForumProfileField");
            migrationBuilder.DropTable(name: "ForumPrivmsgsTo");
            migrationBuilder.DropTable(name: "ForumPrivmsgsRule");
            migrationBuilder.DropTable(name: "ForumPrivmsgsFolder");
            migrationBuilder.DropTable(name: "ForumPrivmsg");
            migrationBuilder.DropTable(name: "ForumPost");
            migrationBuilder.DropTable(name: "ForumPollVote");
            migrationBuilder.DropTable(name: "ForumPollOption");
            migrationBuilder.DropTable(name: "ForumModule");
            migrationBuilder.DropTable(name: "ForumLoginAttempt");
            migrationBuilder.DropTable(name: "ForumLog");
            migrationBuilder.DropTable(name: "ForumLang");
            migrationBuilder.DropTable(name: "ForumIcon");
            migrationBuilder.DropTable(name: "ForumExtensionGroup");
            migrationBuilder.DropTable(name: "ForumExtension");
            migrationBuilder.DropTable(name: "ForumExt");
            migrationBuilder.DropTable(name: "ForumDrafts");
            migrationBuilder.DropTable(name: "ForumConfig");
            migrationBuilder.DropTable(name: "ForumBot");
            migrationBuilder.DropTable(name: "ForumBookmark");
            migrationBuilder.DropTable(name: "ForumBbcode");
            migrationBuilder.DropTable(name: "ForumBanlist");
            migrationBuilder.DropTable(name: "ForumAttachment");
            migrationBuilder.DropTable(name: "Forum");
        }
    }
}
