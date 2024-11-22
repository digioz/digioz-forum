using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumGroup",
                columnTypes: new[] {
                    "varchar(255)", // GroupName
                    "tinyint",      // GroupType
                    "tinyint",      // GroupFounderManage
                    "varchar(6)",   // GroupColour
                    "bigint",       // GroupLegend
                    "varchar(255)", // GroupAvatar
                    "text",         // GroupDesc
                    "varchar(8)",   // GroupDescUid
                    "bigint"        // GroupMaxRecipients
                },
                columns: new[] {
                    "GroupName", "GroupType", "GroupFounderManage", "GroupColour",
                    "GroupLegend", "GroupAvatar", "GroupDesc", "GroupDescUid",
                    "GroupMaxRecipients"
                },
                values: new object[,]
                {
                    {
                        "GUESTS", 3, 0, "",
                        0, "", "", "",
                        5
                    },
                    {
                        "REGISTERED", 3, 0, "",
                        0, "", "", "",
                        5
                    },
                    {
                        "REGISTERED_COPPA", 3, 0, "",
                        0, "", "", "",
                        5
                    },
                    {
                        "GLOBAL_MODERATORS", 3, 0, "00AA00",
                        2, "", "", "",
                        0
                    },
                    {
                        "ADMINISTRATORS", 3, 1, "AA0000",
                        1, "", "", "",
                        0
                    },
                    {
                        "BOTS", 3, 0, "9E8DA7",
                        0, "", "", "",
                        5
                    },
                    {
                        "NEWLY_REGISTERED", 3, 0, "",
                        0, "", "", "",
                        5
                    }
                });

            migrationBuilder.InsertData(
                table: "ForumTeamPage",
                columnTypes: new[] {
                    "bigint",       // GroupId
                    "varchar(255)", // TeamPageName
                    "bigint",       // TeamPagePosition
                    "bigint"        // TeamPageParent
                },
                columns: new[] {
                    "GroupId",
                    "TeamPageName",
                    "TeamPagePosition",
                    "TeamPageParent"
                },
                values: new object[,]
                {
                    {
                        5,      // Administrators group
                        "",
                        1,
                        0
                    },
                    {
                        4,      // Global Moderators group
                        "",
                        2,
                        0
                    }
                });

            migrationBuilder.InsertData(
                table: "ForumUserGroup",
                columnTypes: new[] {
                    "bigint",       // GroupId
                    "int",          // UserId
                    "tinyint",      // UserPending
                    "tinyint"       // GroupLeader
                },
                columns: new[] {
                    "GroupId",
                    "UserId",
                    "UserPending",
                    "GroupLeader"
                },
                values: new object[,]
                {
                    {
                        1,      // GUESTS group
                        1,      // Anonymous user
                        0,
                        0
                    },
                    {
                        2,      // REGISTERED group
                        2,      // Admin user
                        0,
                        0
                    },
                    {
                        4,      // GLOBAL_MODERATORS group
                        2,      // Admin user
                        0,
                        0
                    },
                    {
                        5,      // ADMINISTRATORS group
                        2,      // Admin user
                        0,
                        1       // Group leader
                    }
                });

            migrationBuilder.InsertData(
                table: "ForumRank",
                columnTypes: new[] {
                    "varchar(255)", // RankTitle
                    "bigint",       // RankMin
                    "tinyint",      // RankSpecial
                    "varchar(255)"  // RankImage
                },
                columns: new[] {
                    "RankTitle",
                    "RankMin",
                    "RankSpecial",
                    "RankImage"
                },
                values: new object[,]
                {
                    {
                        "Site Admin",                  // Site Admin rank title
                        0,                             // Minimum posts
                        1,                             // Special rank
                        ""                             // No rank image
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumRank",
                keyColumns: new[] { "RankTitle", "RankSpecial" },
                keyValues: new object[] { "{L_RANKS_SITE_ADMIN_TITLE}", 1 });

            migrationBuilder.DeleteData(
                table: "ForumUserGroup",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ForumUserGroup",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ForumUserGroup",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ForumUserGroup",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ForumTeamPage",
                keyColumns: new[] { "GroupId", "TeamPagePosition" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ForumTeamPage",
                keyColumns: new[] { "GroupId", "TeamPagePosition" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
            table: "ForumGroup",
            keyColumn: "GroupName",
            keyValues: new[]
            {
                "GUESTS",
                "REGISTERED",
                "REGISTERED_COPPA",
                "GLOBAL_MODERATORS",
                "ADMINISTRATORS",
                "BOTS",
                "NEWLY_REGISTERED"
            });
        }
    }
}
