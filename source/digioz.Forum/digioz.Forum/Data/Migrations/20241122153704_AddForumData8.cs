using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumTopic",
                columnTypes: new[] {
                    "varchar(255)",  // TopicTitle
                    "int",           // TopicPoster
                    "int",           // TopicTime
                    "bigint",        // TopicViews
                    "bigint",        // TopicPostsApproved
                    "bigint",        // TopicPostsUnapproved
                    "bigint",        // TopicPostsSoftdeleted
                    "bigint",        // ForumId
                    "tinyint",       // TopicStatus
                    "tinyint",       // TopicType
                    "int",           // TopicFirstPostId
                    "varchar(255)",  // TopicFirstPosterName
                    "varchar(6)",    // TopicFirstPosterColor
                    "int",           // TopicLastPostId
                    "int",           // TopicLastPosterId
                    "varchar(255)",  // TopicLastPosterName
                    "varchar(6)",    // TopicLastPosterColor
                    "varchar(255)",  // TopicLastPostSubject
                    "int",           // TopicLastPostTime
                    "int",           // TopicLastViewTime
                    "varchar(255)",  // PollTitle
                    "tinyint"        // TopicVisibility
                },
                columns: new[]
                {
                    "TopicTitle",
                    "TopicPoster",
                    "TopicTime",
                    "TopicViews",
                    "TopicPostsApproved",
                    "TopicPostsUnapproved",
                    "TopicPostsSoftdeleted",
                    "ForumId",
                    "TopicStatus",
                    "TopicType",
                    "TopicFirstPostId",
                    "TopicFirstPosterName",
                    "TopicFirstPosterColor",
                    "TopicLastPostId",
                    "TopicLastPosterId",
                    "TopicLastPosterName",
                    "TopicLastPosterColor",
                    "TopicLastPostSubject",
                    "TopicLastPostTime",
                    "TopicLastViewTime",
                    "PollTitle",
                    "TopicVisibility"
                },
                values: new object[]
                {
                    "Welcome to phpBB3",      // TopicTitle
                    2,                        // TopicPoster
                    972086460,                // TopicTime
                    0,                        // TopicViews
                    1,                        // TopicPostsApproved
                    0,                        // TopicPostsUnapproved
                    0,                        // TopicPostsSoftdeleted
                    2,                        // ForumId
                    0,                        // TopicStatus
                    0,                        // TopicType
                    1,                        // TopicFirstPostId
                    "Admin",                  // TopicFirstPosterName
                    "AA0000",                 // TopicFirstPosterColor
                    1,                        // TopicLastPostId
                    2,                        // TopicLastPosterId
                    "Admin",                  // TopicLastPosterName
                    "AA0000",                 // TopicLastPosterColor
                    "Welcome to phpBB3",      // TopicLastPostSubject
                    972086460,               // TopicLastPostTime
                    972086460,               // TopicLastViewTime
                    "",                       // PollTitle
                    1                         // TopicVisibility
                });

            migrationBuilder.InsertData(
                table: "ForumPost",
                columnTypes: new[] {
                    "int",           // TopicId
                    "bigint",        // ForumId
                    "int",           // PosterId
                    "bigint",        // IconId
                    "int",           // PostTime
                    "varchar(255)",  // PostUsername
                    "varchar(40)",   // PosterIp
                    "varchar(255)",  // PostSubject
                    "text",          // PostText
                    "varchar(32)",   // PostChecksum
                    "varchar(8)",    // BbcodeUid
                    "tinyint"        // PostVisibility
                },
                columns: new[]
                {
                    "TopicId",
                    "ForumId",
                    "PosterId",
                    "IconId",
                    "PostTime",
                    "PostUsername",
                    "PosterIp",
                    "PostSubject",
                    "PostText",
                    "PostChecksum",
                    "BbcodeUid",
                    "PostVisibility"
                },
                values: new object[]
                {
                    1,                                              // TopicId
                    2,                                              // ForumId
                    2,                                              // PosterId
                    0,                                              // IconId
                    972086460,                                      // PostTime
                    "",                                             // PostUsername
                    "127.0.0.1",                                    // PosterIp
                    "Welcome to phpBB3",                            // PostSubject
                    "This is an example post in your phpBB3 installation. Everything seems to be working. You may delete this post if you like and continue to set up your board. During the installation process your first category and your first forum are assigned an appropriate set of permissions for the predefined usergroups administrators, bots, global moderators, guests, registered users and registered COPPA users. If you also choose to delete your first category and your first forum, do not forget to assign permissions for all these usergroups for all new categories and forums you create. It is recommended to rename your first category and your first forum and copy permissions from these while creating new categories and forums. Have fun!",  // PostText
                    "5dd683b17f641daf84c040bfefc58ce9",            // PostChecksum
                    "",                                             // BbcodeUid
                    1                                               // PostVisibility
                });

            migrationBuilder.InsertData(
                table: "ForumTopicsPosted",
                columnTypes: new[] {
                    "int",           // UserId
                    "int",           // TopicId
                    "tinyint"        // TopicPosted
                },
                columns: new[]
                {
                    "UserId",
                    "TopicId",
                    "TopicPosted"
                },
                values: new object[]
                {
                    2,    // UserId (Admin)
                    1,    // TopicId (Demo topic)
                    1     // TopicPosted (true)
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumTopicsPosted",
                keyColumns: new[] { "UserId", "TopicId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ForumPost",
                keyColumns: new[] { "TopicId", "ForumId", "PostTime" },
                keyValues: new object[] { 1, 2, 972086460 });

            migrationBuilder.DeleteData(
                table: "ForumTopic",
                keyColumns: new[] { "TopicFirstPostId", "ForumId" },
                keyValues: new object[] { 1, 2 });
        }
    }
}
