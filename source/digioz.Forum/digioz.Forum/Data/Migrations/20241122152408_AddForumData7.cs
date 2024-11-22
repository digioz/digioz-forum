using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Admin user - Full user features
            migrationBuilder.InsertData(
                table: "ForumAclUser",
                columnTypes: new[] { "int", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "UserId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 2, 0, 0, 5, 0 });

            // ADMINISTRATOR Group - Full user features
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 5, 0, 0, 5, 0 });

            // ADMINISTRATOR Group - Standard admin permissions
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 5, 0, 0, 1, 0 });

            // REGISTERED group - Standard user features
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 2, 0, 0, 6, 0 });

            // REGISTERED_COPPA group - Standard user features
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 3, 0, 0, 6, 0 });

            // GLOBAL_MODERATORS group - Full user features
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 4, 0, 0, 5, 0 });

            // GLOBAL_MODERATORS group - Full moderator access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 4, 0, 0, 10, 0 });

            // Read only access for first category (ForumId: 1)
            var groupPermissions = new[]
            {
                new { GroupId = 1, Comment = "GUESTS" },
                new { GroupId = 2, Comment = "REGISTERED" },
                new { GroupId = 3, Comment = "REGISTERED_COPPA" },
                new { GroupId = 6, Comment = "BOTS" }
            };

            foreach (var group in groupPermissions)
            {
                migrationBuilder.InsertData(
                    table: "ForumAclGroup",
                    columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                    columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                    values: new object[] { group.GroupId, 1, 0, 17, 0 });
            }

            // GUESTS - Read only access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 1, 2, 0, 17, 0 });

            // REGISTERED - Standard access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 2, 2, 0, 15, 0 });

            // REGISTERED_COPPA - Standard access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 3, 2, 0, 15, 0 });

            // GLOBAL_MODERATORS - Standard access + polls
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 4, 2, 0, 21, 0 });

            // ADMINISTRATORS - Full forum access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 5, 2, 0, 14, 0 });

            // ADMINISTRATORS - Full moderator access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 5, 2, 0, 10, 0 });

            // BOTS - Bot access
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 6, 2, 0, 19, 0 });

            // NEW MEMBERS - PM restrictions (global)
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 7, 0, 0, 23, 0 });

            // NEW MEMBERS - On moderation queue
            migrationBuilder.InsertData(
                table: "ForumAclGroup",
                columnTypes: new[] { "bigint", "bigint", "bigint", "bigint", "tinyint" },
                columns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId", "AuthSetting" },
                values: new object[] { 7, 2, 0, 24, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove ADMINISTRATORS permissions
            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 5, 2, 0, 14 });

            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 5, 2, 0, 10 });

            // Remove BOTS permissions
            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 6, 2, 0, 19 });

            // Remove NEW MEMBERS permissions
            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 7, 0, 0, 23 });

            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 7, 2, 0, 24 });

            // Remove all forum access permissions
            var groupsToRemove = new[] { 1, 2, 3, 4 };
            foreach (var groupId in groupsToRemove)
            {
                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { groupId, 2, 0,
                    groupId == 1 ? 17 :    // GUESTS
                    groupId == 4 ? 21 :    // GLOBAL_MODERATORS
                    15                     // REGISTERED & REGISTERED_COPPA
                    });

                // Remove all read-only permissions for the first category
                migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 1, 1, 0, 17 });

                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 2, 1, 0, 17 });

                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 3, 1, 0, 17 });

                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 6, 1, 0, 17 });

                // Remove REGISTERED group permissions
                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 2, 0, 0, 6 });

                // Remove REGISTERED_COPPA group permissions
                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 3, 0, 0, 6 });

                // Remove GLOBAL_MODERATORS group permissions (both entries)
                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 4, 0, 0, 5 });

                migrationBuilder.DeleteData(
                    table: "ForumAclGroup",
                    keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 4, 0, 0, 10 });

                // Remove GUESTS permissions
                migrationBuilder.Sql(@"
                DELETE FROM ForumAclGroup 
                WHERE GroupId = 1 AND ForumId = 0");

                // Remove Admin user permissions
                migrationBuilder.DeleteData(
                    table: "ForumAclUser",
                    keyColumns: new[] { "UserId", "ForumId", "AuthOptionId", "AuthRoleId" },
                    keyValues: new object[] { 2, 0, 0, 5 });
            }
        }
    }
}
