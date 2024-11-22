using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Standard Admin (RoleId: 1)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 1, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'a_%'
            AND AuthOption NOT IN (
                'a_switchperm',
                'a_jabber',
                'a_phpinfo',
                'a_server',
                'a_backup',
                'a_styles',
                'a_clearlogs',
                'a_modules',
                'a_language',
                'a_email',
                'a_bots',
                'a_search',
                'a_aauth',
                'a_roles'
            )");

            // Forum Admin (RoleId: 2)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 2, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'a_%'
            AND AuthOption IN (
                'a_',
                'a_authgroups',
                'a_authusers',
                'a_fauth',
                'a_forum',
                'a_forumadd',
                'a_forumdel',
                'a_mauth',
                'a_prune',
                'a_uauth',
                'a_viewauth',
                'a_viewlogs'
            )");

            // User and Groups Admin (RoleId: 3)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 3, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'a_%'
            AND AuthOption IN (
                'a_',
                'a_authgroups',
                'a_authusers',
                'a_ban',
                'a_group',
                'a_groupadd',
                'a_groupdel',
                'a_ranks',
                'a_uauth',
                'a_user',
                'a_viewauth',
                'a_viewlogs'
            )");

            // Full Admin (RoleId: 4)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 4, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'a_%'");

            // All Features (RoleId: 5)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 5, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'");

            // Standard Features (RoleId: 6)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 6, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption NOT IN (
                'u_viewonline',
                'u_chggrp',
                'u_chgname',
                'u_ignoreflood',
                'u_pm_flash',
                'u_pm_forward'
            )");

            // Limited Features (RoleId: 7)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 7, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption NOT IN (
                'u_attach',
                'u_viewonline',
                'u_chggrp',
                'u_chgname',
                'u_ignoreflood',
                'u_pm_attach',
                'u_pm_emailpm',
                'u_pm_flash',
                'u_savedrafts',
                'u_search',
                'u_sendemail',
                'u_sendim',
                'u_masspm',
                'u_masspm_group'
            )");

            // No Private Messages - Allowed Features (RoleId: 8, AuthSetting: 1)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 8, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption IN (
                'u_',
                'u_chgavatar',
                'u_chgcensors',
                'u_chgemail',
                'u_chgpasswd',
                'u_download',
                'u_hideonline',
                'u_sig',
                'u_viewprofile'
            )");

            // No Private Messages - Denied Features (RoleId: 8, AuthSetting: 0)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 8, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption IN (
                'u_readpm',
                'u_sendpm',
                'u_masspm',
                'u_masspm_group'
            )");

            // No Avatar - Allowed Features (RoleId: 9, AuthSetting: 1)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 9, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption NOT IN (
                'u_attach',
                'u_chgavatar',
                'u_viewonline',
                'u_chggrp',
                'u_chgname',
                'u_ignoreflood',
                'u_pm_attach',
                'u_pm_emailpm',
                'u_pm_flash',
                'u_savedrafts',
                'u_search',
                'u_sendemail',
                'u_sendim',
                'u_masspm',
                'u_masspm_group'
            )");

            // No Avatar - Explicitly Denied Features (RoleId: 9, AuthSetting: 0)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 9, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption IN (
                'u_chgavatar'
            )");

            // Full Moderator (RoleId: 10)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 10, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'm_%'");

            // Standard Moderator (RoleId: 11)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 11, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'm_%'
            AND AuthOption NOT IN (
                'm_ban',
                'm_chgposter'
            )");

            // Simple Moderator (RoleId: 12)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 12, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'm_%'
            AND AuthOption IN (
                'm_',
                'm_delete',
                'm_softdelete',
                'm_edit',
                'm_info',
                'm_report',
                'm_pm_report'
            )");

            // Queue Moderator (RoleId: 13)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 13, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'm_%'
            AND AuthOption IN (
                'm_',
                'm_approve',
                'm_edit'
            )");

            // Full Access (RoleId: 14)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 14, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'");

            // Standard Access (RoleId: 15)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 15, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption NOT IN (
                'f_announce',
                'f_announce_global',
                'f_flash',
                'f_ignoreflood',
                'f_poll',
                'f_sticky',
                'f_user_lock'
            )");

            // No Access (RoleId: 16)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 16, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption = 'f_'");

            // Read Only Access (RoleId: 17)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 17, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption IN (
                'f_',
                'f_download',
                'f_list',
                'f_list_topics',
                'f_read',
                'f_search',
                'f_subscribe',
                'f_print'
            )");

            // Limited Access (RoleId: 18)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 18, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption NOT IN (
                'f_announce',
                'f_announce_global',
                'f_attach',
                'f_bump',
                'f_delete',
                'f_flash',
                'f_icons',
                'f_ignoreflood',
                'f_poll',
                'f_sticky',
                'f_user_lock',
                'f_votechg'
            )");

            // Bot Access (RoleId: 19)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 19, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption IN (
                'f_',
                'f_download',
                'f_list',
                'f_list_topics',
                'f_read',
                'f_print'
            )");

            // On Moderation Queue - Allowed Features (RoleId: 20, AuthSetting: 1)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 20, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption NOT IN (
                'f_announce',
                'f_announce_global',
                'f_bump',
                'f_delete',
                'f_flash',
                'f_icons',
                'f_ignoreflood',
                'f_poll',
                'f_sticky',
                'f_user_lock',
                'f_votechg',
                'f_noapprove'
            )");

            // On Moderation Queue - Denied Features (RoleId: 20, AuthSetting: 0)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 20, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption IN (
                'f_noapprove'
            )");

            // Standard Access + Polls (RoleId: 21)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 21, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption NOT IN (
                'f_announce',
                'f_announce_global',
                'f_flash',
                'f_ignoreflood',
                'f_sticky',
                'f_user_lock'
            )");

            // Limited Access + Polls (RoleId: 22)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 22, AuthOptionId, 1
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption NOT IN (
                'f_announce',
                'f_announce_global',
                'f_attach',
                'f_bump',
                'f_delete',
                'f_flash',
                'f_icons',
                'f_ignoreflood',
                'f_sticky',
                'f_user_lock',
                'f_votechg'
            )");

            // New Member - User Restrictions (RoleId: 23)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 23, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'u_%'
            AND AuthOption IN (
                'u_sendpm',
                'u_masspm',
                'u_masspm_group',
                'u_chgprofileinfo'
            )");

            // New Member - Forum Restrictions (RoleId: 24)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclRoleData (RoleId, AuthOptionId, AuthSetting)
            SELECT 24, AuthOptionId, 0
            FROM ForumAclOption 
            WHERE AuthOption LIKE 'f_%'
            AND AuthOption IN (
                'f_noapprove'
            )");

            // GUESTS - Basic permissions (download and search)
            migrationBuilder.Sql(@"
            INSERT INTO ForumAclGroup (GroupId, ForumId, AuthOptionId, AuthRoleId, AuthSetting)
            SELECT 1, 0, AuthOptionId, 0, 1
            FROM ForumAclOption 
            WHERE AuthOption IN (
                'u_',
                'u_download',
                'u_search'
            )");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove ADMINISTRATOR group permissions
            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 5, 0, 0, 5 });

            migrationBuilder.DeleteData(
                table: "ForumAclGroup",
                keyColumns: new[] { "GroupId", "ForumId", "AuthOptionId", "AuthRoleId" },
                keyValues: new object[] { 5, 0, 0, 1 });

            // Remove all poll access and new member role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId IN (21, 22, 23, 24)");

            // Remove all special access role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId IN (18, 19, 20)");

            // Remove all forum access role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId IN (14, 15, 16, 17)");

            // Remove all moderator role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId IN (10, 11, 12, 13)");

            // Remove all No Avatar role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 9");

            // Remove all No Private Messages role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 8");

            // Remove Standard Features role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 6");

            // Remove Limited Features role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 7");

            // Remove User and Groups Admin role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 3");

            // Remove Full Admin role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 4");

            // Remove All Features role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 5");

            // Remove Forum Admin role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 2");

            // Remove Standard Admin role data
            migrationBuilder.Sql("DELETE FROM ForumAclRoleData WHERE RoleId = 1");
        }
    }
}
