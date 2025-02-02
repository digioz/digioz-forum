using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class ForumPermissionTableAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumPermission",
                columns: table => new
                {
                    ForumPermissionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPermission", x => x.ForumPermissionId);
                });

            // Insert data for ForumId 1 and 2
            migrationBuilder.Sql(@"
                    DECLARE @RegisteredRoleId NVARCHAR(450) = (SELECT Id FROM AspNetRoles WHERE Name = 'Registered');
                    DECLARE @AdministratorsRoleId NVARCHAR(450) = (SELECT Id FROM AspNetRoles WHERE Name = 'Administrators');
                    DECLARE @ModeratorsRoleId NVARCHAR(450) = (SELECT Id FROM AspNetRoles WHERE Name = 'Moderators');
                    DECLARE @GuestsRoleId NVARCHAR(450) = (SELECT Id FROM AspNetRoles WHERE Name = 'Guests');
                    DECLARE @BotsRoleId NVARCHAR(450) = (SELECT Id FROM AspNetRoles WHERE Name = 'Bots');

                    INSERT INTO ForumPermission (ForumId, RoleId, IsReadOnly) VALUES
                    (1, @RegisteredRoleId, 0),
                    (1, @AdministratorsRoleId, 0),
                    (1, @ModeratorsRoleId, 0),
                    (1, @GuestsRoleId, 1),
                    (1, @BotsRoleId, 1),
                    (2, @RegisteredRoleId, 0),
                    (2, @AdministratorsRoleId, 0),
                    (2, @ModeratorsRoleId, 0),
                    (2, @GuestsRoleId, 1),
                    (2, @BotsRoleId, 1);
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumPermission");
        }
    }
}
