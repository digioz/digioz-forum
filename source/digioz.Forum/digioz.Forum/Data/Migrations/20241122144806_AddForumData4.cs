using digioz.Forum.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create password hasher
            var hasher = new PasswordHasher<IdentityUser>();

            // Generate unique values
            var userId1 = Guid.NewGuid().ToString();
            var securityStamp = Guid.NewGuid().ToString();
            var concurrencyStamp = Guid.NewGuid().ToString();

            // Create admin user
            var user = new
            {
                Id = userId1,
                UserName = "admin@yourdomain.com",
                NormalizedUserName = "ADMIN@YOURDOMAIN.COM",
                Email = "admin@yourdomain.com",
                NormalizedEmail = "ADMIN@YOURDOMAIN.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Pass@word1"),
                SecurityStamp = securityStamp,
                ConcurrencyStamp = concurrencyStamp,
                PhoneNumber = (string)null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = (DateTimeOffset?)null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columnTypes: new[] {
                    "nvarchar(450)",    // Id
                    "nvarchar(256)",    // UserName
                    "nvarchar(256)",    // NormalizedUserName
                    "nvarchar(256)",    // Email
                    "nvarchar(256)",    // NormalizedEmail
                    "bit",              // EmailConfirmed
                    "nvarchar(max)",    // PasswordHash
                    "nvarchar(max)",    // SecurityStamp
                    "nvarchar(max)",    // ConcurrencyStamp
                    "nvarchar(max)",    // PhoneNumber
                    "bit",              // PhoneNumberConfirmed
                    "bit",              // TwoFactorEnabled
                    "datetimeoffset",   // LockoutEnd
                    "bit",              // LockoutEnabled
                    "int"               // AccessFailedCount
                },
                columns: new[] {
                "Id",
                "UserName",
                "NormalizedUserName",
                "Email",
                "NormalizedEmail",
                "EmailConfirmed",
                "PasswordHash",
                "SecurityStamp",
                "ConcurrencyStamp",
                "PhoneNumber",
                "PhoneNumberConfirmed",
                "TwoFactorEnabled",
                "LockoutEnd",
                "LockoutEnabled",
                "AccessFailedCount"
                },
                values: new object[] {
                user.Id,
                user.UserName,
                user.NormalizedUserName,
                user.Email,
                user.NormalizedEmail,
                user.EmailConfirmed,
                user.PasswordHash,
                user.SecurityStamp,
                user.ConcurrencyStamp,
                user.PhoneNumber,
                user.PhoneNumberConfirmed,
                user.TwoFactorEnabled,
                user.LockoutEnd,
                user.LockoutEnabled,
                user.AccessFailedCount
                });

            // Create password hasher
            hasher = new PasswordHasher<IdentityUser>();

            // Generate unique values
            var userId2 = Guid.NewGuid().ToString();
            securityStamp = Guid.NewGuid().ToString();
            concurrencyStamp = Guid.NewGuid().ToString();
            var stringHelper = new StringHelper();
            var passAnonymous = stringHelper.GenerateRandomPassword();

            // Create anonymous user
            user = new
            {
                Id = userId2,
                UserName = "anonymous@yourdomain.com",
                NormalizedUserName = "ANONYMOUS@YOURDOMAIN.COM",
                Email = "anonymous@yourdomain.com",
                NormalizedEmail = "ANONYMOUS@YOURDOMAIN.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, passAnonymous),
                SecurityStamp = securityStamp,
                ConcurrencyStamp = concurrencyStamp,
                PhoneNumber = (string)null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = (DateTimeOffset?)null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columnTypes: new[] {
                    "nvarchar(450)",    // Id
                    "nvarchar(256)",    // UserName
                    "nvarchar(256)",    // NormalizedUserName
                    "nvarchar(256)",    // Email
                    "nvarchar(256)",    // NormalizedEmail
                    "bit",              // EmailConfirmed
                    "nvarchar(max)",    // PasswordHash
                    "nvarchar(max)",    // SecurityStamp
                    "nvarchar(max)",    // ConcurrencyStamp
                    "nvarchar(max)",    // PhoneNumber
                    "bit",              // PhoneNumberConfirmed
                    "bit",              // TwoFactorEnabled
                    "datetimeoffset",   // LockoutEnd
                    "bit",              // LockoutEnabled
                    "int"               // AccessFailedCount
                },
                columns: new[] {
                "Id",
                "UserName",
                "NormalizedUserName",
                "Email",
                "NormalizedEmail",
                "EmailConfirmed",
                "PasswordHash",
                "SecurityStamp",
                "ConcurrencyStamp",
                "PhoneNumber",
                "PhoneNumberConfirmed",
                "TwoFactorEnabled",
                "LockoutEnd",
                "LockoutEnabled",
                "AccessFailedCount"
                },
                values: new object[] {
                user.Id,
                user.UserName,
                user.NormalizedUserName,
                user.Email,
                user.NormalizedEmail,
                user.EmailConfirmed,
                user.PasswordHash,
                user.SecurityStamp,
                user.ConcurrencyStamp,
                user.PhoneNumber,
                user.PhoneNumberConfirmed,
                user.TwoFactorEnabled,
                user.LockoutEnd,
                user.LockoutEnabled,
                user.AccessFailedCount
                });

            migrationBuilder.InsertData(
                table: "ForumUser",
                columnTypes: new[] {
                    "varchar(128)", // UserId
                    "tinyint",      // UserType
                    "bigint",       // GroupId
                    "varchar(255)", // UserName
                    "varchar(255)", // UserNameClean
                    "int",          // UserRegdate
                    "varchar(100)", // UserEmail
                    "varchar(30)",  // UserLang
                    "bigint",       // UserStyle
                    "bigint",       // UserRank
                    "varchar(6)",   // UserColor
                    "bigint",       // UserPosts
                    "text",         // UserPermissions
                    "varchar(40)",  // UserIp
                    "varchar(10)",  // UserBirthday
                    "varchar(200)", // UserLastPage
                    "varchar(10)",  // UserLastConfirmKey
                    "varchar(1)",   // UserPostSortbyType
                    "varchar(1)",   // UserPostSortbyDir
                    "varchar(1)",   // UserTopicSortbyType
                    "varchar(1)",   // UserTopicSortbyDir
                    "varchar(255)", // UserAvatar
                    "text",         // UserSig
                    "varchar(8)",   // UserSigBbcodeUid
                    "varchar(255)", // UserJabber
                    "varchar(32)",  // UserActkey
                    "int",          // UserActkeyExpiration
                    "varchar(255)",  // UserNewpasswd
                    "tinyint"       // UserAllowMassemail
                },
                columns: new[] {
                    "UserId", "UserType", "GroupId", "UserName", "UserNameClean", "UserRegdate",
                    "UserEmail", "UserLang", "UserStyle", "UserRank", "UserColor",
                    "UserPosts", "UserPermissions", "UserIp", "UserBirthday",
                    "UserLastPage", "UserLastConfirmKey", "UserPostSortbyType",
                    "UserPostSortbyDir", "UserTopicSortbyType", "UserTopicSortbyDir",
                    "UserAvatar", "UserSig", "UserSigBbcodeUid", "UserJabber",
                    "UserActkey", "UserActkeyExpiration", "UserNewpasswd", "UserAllowMassemail"
                },
                values: new object[,]
                {
                    {
                        // Anonymous user
                        userId2, 2, 1, "Anonymous", "anonymous", 0,
                        "", "en", 1, 0, "",
                        0, "", "", "",
                        "", "", "t",
                        "a", "t", "d",
                        "", "", "", "",
                        "", 0, "", 0
                    },
                    {
                        // Admin user
                        userId1, 3, 5, "Admin", "admin", 0,
                        "admin@yourdomain.com", "en", 1, 1, "AA0000",
                        1, "", "", "",
                        "", "", "t",
                        "a", "t", "d",
                        "", "", "", "",
                        "", 0, "", 1
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumUser",
                keyColumns: new[] { "UserName", "UserType" },
                keyValues: new object[] { "Anonymous", 2 });

            migrationBuilder.DeleteData(
                table: "ForumUser",
                keyColumns: new[] { "UserName", "UserType" },
                keyValues: new object[] { "Admin", 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Email",
                keyValue: "anonymous@yourdomain.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Email",
                keyValue: "admin@yourdomain.com");
        }
    }
}
