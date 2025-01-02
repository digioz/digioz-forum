using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumStyle",
                columnTypes: new[] { "varchar(255)", "varchar(255)", "tinyint", "varchar(100)", "varchar(255)", "int", "text" },
                columns: new[] { "StyleName", "StyleCopyright", "StyleActive", "StylePath", "BbcodeBitField", "StyleParentId", "StyleParentTree" },
                values: new object[,]
                {
                    { "prosilver", "&copy; phpBB Limited", 1, "prosilver", "//g=", 0, "" },
                    { "prosilver_dark", "&copy; phpBB Limited", 0, "prosilver_dark", "//g=", 0, "" }
                });

            migrationBuilder.InsertData(
                table: "Forum",
                columnTypes: new[] {
                    "varchar(255)", // ForumName
                    "text",         // ForumDesc
                    "bigint",       // LeftId
                    "bigint",       // RightId
                    "bigint",       // ParentId
                    "tinyint",      // ForumType
                    "bigint",       // ForumPostsApproved
                    "bigint",       // ForumPostsUnapproved
                    "bigint",       // ForumPostsSoftDeleted
                    "bigint",       // ForumTopicsApproved
                    "bigint",       // ForumTopicsUnapproved
                    "bigint",       // ForumTopicsSoftDeleted
                    "int",          // ForumLastPostId
                    "int",          // ForumLastPosterId
                    "varchar(255)", // ForumLastPosterName
                    "varchar(6)",   // ForumLastPosterColour
                    "varchar(255)", // ForumLastPostSubject
                    "int",          // ForumLastPostTime
                    "varchar(255)", // ForumLink
                    "varchar(255)", // ForumPassword
                    "varchar(255)", // ForumImage
                    "text",         // ForumRules
                    "varchar(255)", // ForumRulesLink
                    "varchar(8)",   // ForumRulesUid
                    "varchar(8)",   // ForumDescUid
                    "bigint",       // PruneFreq
                    "bigint",       // PruneDays
                    "bigint",       // PruneViewed
                    "text",         // ForumParents
                    "tinyint"       // ForumFlags
                },
                columns: new[] {
                    "ForumName", "ForumDesc", "LeftId", "RightId", "ParentId", "ForumType",
                    "ForumPostsApproved", "ForumPostsUnapproved", "ForumPostsSoftDeleted",
                    "ForumTopicsApproved", "ForumTopicsUnapproved", "ForumTopicsSoftDeleted",
                    "ForumLastPostId", "ForumLastPosterId", "ForumLastPosterName",
                    "ForumLastPosterColour", "ForumLastPostSubject", "ForumLastPostTime",
                    "ForumLink", "ForumPassword", "ForumImage", "ForumRules", "ForumRulesLink",
                    "ForumRulesUid", "ForumDescUid", "PruneFreq", "PruneDays", "PruneViewed",
                    "ForumParents", "ForumFlags"
                },
                values: new object[,]
                {
                    {
                        "Your First Category", // ForumName
                        "", // ForumDesc
                        1, // LeftId
                        4, // RightId
                        0, // ParentId
                        0, // ForumType
                        0, // ForumPostsApproved
                        0, // ForumPostsUnapproved
                        0, // ForumPostsSoftDeleted
                        0, // ForumTopicsApproved
                        0, // ForumTopicsUnapproved
                        0, // ForumTopicsSoftDeleted
                        1, // ForumLastPostId
                        2, // ForumLastPosterId
                        "Admin", // ForumLastPosterName
                        "AA0000", // ForumLastPosterColour
                        "", // ForumLastPostSubject
                        972086460, // ForumLastPostTime
                        "", // ForumLink
                        "", // ForumPassword
                        "", // ForumImage
                        "", // ForumRules
                        "", // ForumRulesLink
                        "", // ForumRulesUid
                        "", // ForumDescUid
                        0, // PruneFreq
                        0, // PruneDays
                        0, // PruneViewed
                        "", // ForumParents
                        32 // ForumFlags
                    },
                    {
                        "Your First Forum", // ForumName
                        "Description of your first forum.", // ForumDesc
                        2, // LeftId
                        3, // RightId
                        1, // ParentId
                        1, // ForumType
                        1, // ForumPostsApproved
                        0, // ForumPostsUnapproved
                        0, // ForumPostsSoftDeleted
                        1, // ForumTopicsApproved
                        0, // ForumTopicsUnapproved
                        0, // ForumTopicsSoftDeleted
                        1, // ForumLastPostId
                        2, // ForumLastPosterId
                        "Admin", // ForumLastPosterName
                        "AA0000", // ForumLastPosterColour
                        "Welcome to DigiozBB!", // ForumLastPostSubject
                        972086460, // ForumLastPostTime
                        "", // ForumLink
                        "", // ForumPassword
                        "", // ForumImage
                        "", // ForumRules
                        "", // ForumRulesLink
                        "", // ForumRulesUid
                        "", // ForumDescUid
                        1, // PruneFreq
                        7, // PruneDays
                        7, // PruneViewed
                        "", // ForumParents
                        48 // ForumFlags
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete the test forum first (child)
            migrationBuilder.DeleteData(
                table: "Forum",
                keyColumns: new[] { "ForumName", "LeftId", "RightId", "ParentId" },
                keyValues: new object[] { "Your First Category", 2, 3, 1 });

            // Then delete the category (parent)
            migrationBuilder.DeleteData(
                table: "Forum",
                keyColumns: new[] { "ForumName", "LeftId", "RightId", "ParentId" },
                keyValues: new object[] { "Your First Forum", 1, 4, 0 });

            migrationBuilder.DeleteData(
                table: "ForumStyle",
                keyColumn: "StyleName",
                keyValue: "prosilver");
        }
    }
}
