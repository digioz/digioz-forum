using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumAclOption",
                columnTypes: new[] { "varchar(50)", "tinyint" },
                columns: new[] { "AuthOption", "IsLocal" },
                values: new object[,]
                {
                    { "f_", 1 },
                    { "f_announce", 1 },
                    { "f_announce_global", 1 },
                    { "f_attach", 1 },
                    { "f_bbcode", 1 },
                    { "f_bump", 1 },
                    { "f_delete", 1 },
                    { "f_download", 1 },
                    { "f_edit", 1 },
                    { "f_email", 1 },
                    { "f_flash", 1 },
                    { "f_icons", 1 },
                    { "f_ignoreflood", 1 },
                    { "f_img", 1 },
                    { "f_list", 1 },
                    { "f_list_topics", 1 },
                    { "f_noapprove", 1 },
                    { "f_poll", 1 },
                    { "f_post", 1 },
                    { "f_postcount", 1 },
                    { "f_print", 1 },
                    { "f_read", 1 },
                    { "f_reply", 1 },
                    { "f_report", 1 },
                    { "f_search", 1 },
                    { "f_sigs", 1 },
                    { "f_smilies", 1 },
                    { "f_sticky", 1 },
                    { "f_subscribe", 1 },
                    { "f_user_lock", 1 },
                    { "f_vote", 1 },
                    { "f_votechg", 1 },
                    { "f_softdelete", 1 }
                });

            migrationBuilder.InsertData(
                table: "ForumAclOption",
                columnTypes: new[] { "varchar(50)", "tinyint", "tinyint" },
                columns: new[] { "AuthOption", "IsLocal", "IsGlobal" },
                values: new object[,]
                {
                    { "m_", 1, 1 },
                    { "m_approve", 1, 1 },
                    { "m_chgposter", 1, 1 },
                    { "m_delete", 1, 1 },
                    { "m_edit", 1, 1 },
                    { "m_info", 1, 1 },
                    { "m_lock", 1, 1 },
                    { "m_merge", 1, 1 },
                    { "m_move", 1, 1 },
                    { "m_report", 1, 1 },
                    { "m_split", 1, 1 },
                    { "m_softdelete", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ForumAclOption",
                columnTypes: new[] { "varchar(50)", "tinyint", "tinyint" },
                columns: new[] { "AuthOption", "IsLocal", "IsGlobal" },
                values: new object[,]
                {
                    { "m_ban", 0, 1 },
                    { "m_pm_report", 0, 1 },
                    { "m_warn", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "ForumAclOption",
                columnTypes: new[] { "varchar(50)", "tinyint", "tinyint" },
                columns: new[] { "AuthOption", "IsGlobal", "IsLocal" },
                values: new object[,]
                {
                    { "a_", 1, 0 },
                    { "a_aauth", 1, 0 },
                    { "a_attach", 1, 0 },
                    { "a_authgroups", 1, 0 },
                    { "a_authusers", 1, 0 },
                    { "a_backup", 1, 0 },
                    { "a_ban", 1, 0 },
                    { "a_bbcode", 1, 0 },
                    { "a_board", 1, 0 },
                    { "a_bots", 1, 0 },
                    { "a_clearlogs", 1, 0 },
                    { "a_email", 1, 0 },
                    { "a_extensions", 1, 0 },
                    { "a_fauth", 1, 0 },
                    { "a_forum", 1, 0 },
                    { "a_forumadd", 1, 0 },
                    { "a_forumdel", 1, 0 },
                    { "a_group", 1, 0 },
                    { "a_groupadd", 1, 0 },
                    { "a_groupdel", 1, 0 },
                    { "a_icons", 1, 0 },
                    { "a_jabber", 1, 0 },
                    { "a_language", 1, 0 },
                    { "a_mauth", 1, 0 },
                    { "a_modules", 1, 0 },
                    { "a_names", 1, 0 },
                    { "a_phpinfo", 1, 0 },
                    { "a_profile", 1, 0 },
                    { "a_prune", 1, 0 },
                    { "a_ranks", 1, 0 },
                    { "a_reasons", 1, 0 },
                    { "a_roles", 1, 0 },
                    { "a_search", 1, 0 },
                    { "a_server", 1, 0 },
                    { "a_styles", 1, 0 },
                    { "a_switchperm", 1, 0 },
                    { "a_uauth", 1, 0 },
                    { "a_user", 1, 0 },
                    { "a_userdel", 1, 0 },
                    { "a_viewauth", 1, 0 },
                    { "a_viewlogs", 1, 0 },
                    { "a_words", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ForumAclOption",
                columnTypes: new[] { "varchar(50)", "tinyint", "tinyint" },
                columns: new[] { "AuthOption", "IsGlobal", "IsLocal" },
                values: new object[,]
                {
                    { "u_", 1, 0 },
                    { "u_attach", 1, 0 },
                    { "u_chgavatar", 1, 0 },
                    { "u_chgcensors", 1, 0 },
                    { "u_chgemail", 1, 0 },
                    { "u_chggrp", 1, 0 },
                    { "u_chgname", 1, 0 },
                    { "u_chgpasswd", 1, 0 },
                    { "u_chgprofileinfo", 1, 0 },
                    { "u_download", 1, 0 },
                    { "u_emoji", 1, 0 },
                    { "u_hideonline", 1, 0 },
                    { "u_ignoreflood", 1, 0 },
                    { "u_masspm", 1, 0 },
                    { "u_masspm_group", 1, 0 },
                    { "u_pm_attach", 1, 0 },
                    { "u_pm_bbcode", 1, 0 },
                    { "u_pm_delete", 1, 0 },
                    { "u_pm_download", 1, 0 },
                    { "u_pm_edit", 1, 0 },
                    { "u_pm_emailpm", 1, 0 },
                    { "u_pm_flash", 1, 0 },
                    { "u_pm_forward", 1, 0 },
                    { "u_pm_img", 1, 0 },
                    { "u_pm_printpm", 1, 0 },
                    { "u_pm_smilies", 1, 0 },
                    { "u_readpm", 1, 0 },
                    { "u_savedrafts", 1, 0 },
                    { "u_search", 1, 0 },
                    { "u_sendemail", 1, 0 },
                    { "u_sendim", 1, 0 },
                    { "u_sendpm", 1, 0 },
                    { "u_sig", 1, 0 },
                    { "u_viewonline", 1, 0 },
                    { "u_viewprofile", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "ForumAclRole",
                columnTypes: new[] { "varchar(255)", "text", "varchar(10)", "smallint" },
                columns: new[] { "RoleName", "RoleDescription", "RoleType", "RoleOrder" },
                values: new object[,]
                {
                    // Admin Roles
                    { "ROLE_ADMIN_STANDARD", "ROLE_DESCRIPTION_ADMIN_STANDARD", "a_", 1 },
                    { "ROLE_ADMIN_FORUM", "ROLE_DESCRIPTION_ADMIN_FORUM", "a_", 3 },
                    { "ROLE_ADMIN_USERGROUP", "ROLE_DESCRIPTION_ADMIN_USERGROUP", "a_", 4 },
                    { "ROLE_ADMIN_FULL", "ROLE_DESCRIPTION_ADMIN_FULL", "a_", 2 },

                    // User Roles
                    { "ROLE_USER_FULL", "ROLE_DESCRIPTION_USER_FULL", "u_", 3 },
                    { "ROLE_USER_STANDARD", "ROLE_DESCRIPTION_USER_STANDARD", "u_", 1 },
                    { "ROLE_USER_LIMITED", "ROLE_DESCRIPTION_USER_LIMITED", "u_", 2 },
                    { "ROLE_USER_NOPM", "ROLE_DESCRIPTION_USER_NOPM", "u_", 4 },
                    { "ROLE_USER_NOAVATAR", "ROLE_DESCRIPTION_USER_NOAVATAR", "u_", 5 },
                    { "ROLE_USER_NEW_MEMBER", "ROLE_DESCRIPTION_USER_NEW_MEMBER", "u_", 6 },

                    // Moderator Roles
                    { "ROLE_MOD_FULL", "ROLE_DESCRIPTION_MOD_FULL", "m_", 3 },
                    { "ROLE_MOD_STANDARD", "ROLE_DESCRIPTION_MOD_STANDARD", "m_", 1 },
                    { "ROLE_MOD_SIMPLE", "ROLE_DESCRIPTION_MOD_SIMPLE", "m_", 2 },
                    { "ROLE_MOD_QUEUE", "ROLE_DESCRIPTION_MOD_QUEUE", "m_", 4 },

                    // Forum Roles
                    { "ROLE_FORUM_FULL", "ROLE_DESCRIPTION_FORUM_FULL", "f_", 7 },
                    { "ROLE_FORUM_STANDARD", "ROLE_DESCRIPTION_FORUM_STANDARD", "f_", 5 },
                    { "ROLE_FORUM_NOACCESS", "ROLE_DESCRIPTION_FORUM_NOACCESS", "f_", 1 },
                    { "ROLE_FORUM_READONLY", "ROLE_DESCRIPTION_FORUM_READONLY", "f_", 2 },
                    { "ROLE_FORUM_LIMITED", "ROLE_DESCRIPTION_FORUM_LIMITED", "f_", 3 },
                    { "ROLE_FORUM_BOT", "ROLE_DESCRIPTION_FORUM_BOT", "f_", 9 },
                    { "ROLE_FORUM_ONQUEUE", "ROLE_DESCRIPTION_FORUM_ONQUEUE", "f_", 8 },
                    { "ROLE_FORUM_POLLS", "ROLE_DESCRIPTION_FORUM_POLLS", "f_", 6 },
                    { "ROLE_FORUM_LIMITED_POLLS", "ROLE_DESCRIPTION_FORUM_LIMITED_POLLS", "f_", 4 },
                    { "ROLE_FORUM_NEW_MEMBER", "ROLE_DESCRIPTION_FORUM_NEW_MEMBER", "f_", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumAclRole",
                keyColumn: "RoleName",
                keyValues: new[]
                {
                    "ROLE_ADMIN_STANDARD",
                    "ROLE_ADMIN_FORUM",
                    "ROLE_ADMIN_USERGROUP",
                    "ROLE_ADMIN_FULL",
                    "ROLE_USER_FULL",
                    "ROLE_USER_STANDARD",
                    "ROLE_USER_LIMITED",
                    "ROLE_USER_NOPM",
                    "ROLE_USER_NOAVATAR",
                    "ROLE_USER_NEW_MEMBER",
                    "ROLE_MOD_FULL",
                    "ROLE_MOD_STANDARD",
                    "ROLE_MOD_SIMPLE",
                    "ROLE_MOD_QUEUE",
                    "ROLE_FORUM_FULL",
                    "ROLE_FORUM_STANDARD",
                    "ROLE_FORUM_NOACCESS",
                    "ROLE_FORUM_READONLY",
                    "ROLE_FORUM_LIMITED",
                    "ROLE_FORUM_BOT",
                    "ROLE_FORUM_ONQUEUE",
                    "ROLE_FORUM_POLLS",
                    "ROLE_FORUM_LIMITED_POLLS",
                    "ROLE_FORUM_NEW_MEMBER"
                });

            migrationBuilder.DeleteData(
                table: "ForumAclOption",
                keyColumn: "AuthOption",
                keyValues: new[]
                {
                    "u_",
                    "u_attach",
                    "u_chgavatar",
                    "u_chgcensors",
                    "u_chgemail",
                    "u_chggrp",
                    "u_chgname",
                    "u_chgpasswd",
                    "u_chgprofileinfo",
                    "u_download",
                    "u_emoji",
                    "u_hideonline",
                    "u_ignoreflood",
                    "u_masspm",
                    "u_masspm_group",
                    "u_pm_attach",
                    "u_pm_bbcode",
                    "u_pm_delete",
                    "u_pm_download",
                    "u_pm_edit",
                    "u_pm_emailpm",
                    "u_pm_flash",
                    "u_pm_forward",
                    "u_pm_img",
                    "u_pm_printpm",
                    "u_pm_smilies",
                    "u_readpm",
                    "u_savedrafts",
                    "u_search",
                    "u_sendemail",
                    "u_sendim",
                    "u_sendpm",
                    "u_sig",
                    "u_viewonline",
                    "u_viewprofile"
                });

            migrationBuilder.DeleteData(
                table: "ForumAclOption",
                keyColumn: "AuthOption",
                keyValues: new[]
                {
                    "a_",
                    "a_aauth",
                    "a_attach",
                    "a_authgroups",
                    "a_authusers",
                    "a_backup",
                    "a_ban",
                    "a_bbcode",
                    "a_board",
                    "a_bots",
                    "a_clearlogs",
                    "a_email",
                    "a_extensions",
                    "a_fauth",
                    "a_forum",
                    "a_forumadd",
                    "a_forumdel",
                    "a_group",
                    "a_groupadd",
                    "a_groupdel",
                    "a_icons",
                    "a_jabber",
                    "a_language",
                    "a_mauth",
                    "a_modules",
                    "a_names",
                    "a_phpinfo",
                    "a_profile",
                    "a_prune",
                    "a_ranks",
                    "a_reasons",
                    "a_roles",
                    "a_search",
                    "a_server",
                    "a_styles",
                    "a_switchperm",
                    "a_uauth",
                    "a_user",
                    "a_userdel",
                    "a_viewauth",
                    "a_viewlogs",
                    "a_words"
                });

            migrationBuilder.DeleteData(
                table: "ForumAclOption",
                keyColumn: "AuthOption",
                keyValues: new[]
                {
                    "m_ban",
                    "m_pm_report",
                    "m_warn"
                });

            migrationBuilder.DeleteData(
                table: "ForumAclOption",
                keyColumn: "AuthOption",
                keyValues: new[]
                {
                    "m_",
                    "m_approve",
                    "m_chgposter",
                    "m_delete",
                    "m_edit",
                    "m_info",
                    "m_lock",
                    "m_merge",
                    "m_move",
                    "m_report",
                    "m_split",
                    "m_softdelete"
                });

            migrationBuilder.DeleteData(
                table: "ForumAclOption",
                keyColumn: "AuthOption",
                keyValues: new[]
                {
                    "f_",
                    "f_announce",
                    "f_announce_global",
                    "f_attach",
                    "f_bbcode",
                    "f_bump",
                    "f_delete",
                    "f_download",
                    "f_edit",
                    "f_email",
                    "f_flash",
                    "f_icons",
                    "f_ignoreflood",
                    "f_img",
                    "f_list",
                    "f_list_topics",
                    "f_noapprove",
                    "f_poll",
                    "f_post",
                    "f_postcount",
                    "f_print",
                    "f_read",
                    "f_reply",
                    "f_report",
                    "f_search",
                    "f_sigs",
                    "f_smilies",
                    "f_sticky",
                    "f_subscribe",
                    "f_user_lock",
                    "f_vote",
                    "f_votechg",
                    "f_softdelete"
                });
        }
    }
}
