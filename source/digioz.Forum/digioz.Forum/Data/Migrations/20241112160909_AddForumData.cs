using digioz.Forum.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumConfig",
                columnTypes: new[] { "nvarchar(255)", "nvarchar(255)", "tinyint" },
                columns: new[] { "ConfigName", "ConfigValue", "IsDynamic" },
                values: new object[,]
                {
                    { "active_sessions", "0", 0 },
                    { "allow_attachments", "1", 0 },
                    { "allow_autologin", "1", 0 },
                    { "allow_avatar", "1", 0 },
                    { "allow_avatar_gravatar", "0", 0 },
                    { "allow_avatar_local", "0", 0 },
                    { "allow_avatar_remote", "0", 0 },
                    { "allow_avatar_remote_upload", "0", 0 },
                    { "allow_avatar_upload", "1", 0 },
                    { "allow_bbcode", "1", 0 },
                    { "allow_birthdays", "1", 0 },
                    { "allow_board_notifications", "1", 0 },
                    { "allow_bookmarks", "1", 0 },
                    { "allow_cdn", "0", 0 },
                    { "allow_emailreuse", "0", 0 },
                    { "allow_forum_notify", "1", 0 },
                    { "allow_live_searches", "1", 0 },
                    { "allow_mass_pm", "1", 0 },
                    { "allow_name_chars", "USERNAME_CHARS_ANY", 0 },
                    { "allow_namechange", "0", 0 },
                    { "allow_nocensors", "0", 0 },
                    { "allow_password_reset", "1", 0 },
                    { "allow_pm_attach", "0", 0 },
                    { "allow_pm_report", "1", 0 },
                    { "allow_post_flash", "1", 0 },
                    { "allow_post_links", "1", 0 },
                    { "allow_privmsg", "1", 0 },
                    { "allow_quick_reply", "1", 0 },
                    { "allow_sig", "1", 0 },
                    { "allow_sig_bbcode", "1", 0 },
                    { "allow_sig_flash", "0", 0 },
                    { "allow_sig_img", "1", 0 },
                    { "allow_sig_links", "1", 0 },
                    { "allow_sig_pm", "1", 0 },
                    { "allow_sig_smilies", "1", 0 },
                    { "allow_smilies", "1", 0 },
                    { "allow_topic_notify", "1", 0 },
                    { "allowed_schemes_links", "http,https,ftp", 0 },
                    { "assets_version", "1", 0 },
                    { "attachment_quota", "52428800", 0 },
                    { "auth_bbcode_pm", "1", 0 },
                    { "auth_flash_pm", "0", 0 },
                    { "auth_img_pm", "1", 0 },
                    { "auth_method", "db", 0 },
                    { "auth_smilies_pm", "1", 0 },
                    { "avatar_filesize", "6144", 0 },
                    { "avatar_gallery_path", "images/avatars/gallery", 0 },
                    { "avatar_max_height", "90", 0 },
                    { "avatar_max_width", "90", 0 },
                    { "avatar_min_height", "20", 0 },
                    { "avatar_min_width", "20", 0 },
                    { "avatar_path", "images/avatars/upload", 0 },
                    { "avatar_salt", "phpbb_avatar", 0 },
                    { "board_contact", "contact@yourdomain.tld", 0 },
                    { "board_contact_name", "", 0 },
                    { "board_disable", "0", 0 },
                    { "board_disable_msg", "", 0 },
                    { "board_email", "address@yourdomain.tld", 0 },
                    { "board_email_form", "0", 0 },
                    { "board_email_sig", "{L_CONFIG_BOARD_EMAIL_SIG}", 0 },
                    { "board_hide_emails", "1", 0 },
                    { "board_index_text", "", 0 },
                    { "board_timezone", "UTC", 0 },
                    { "browser_check", "1", 0 },
                    { "bump_interval", "10", 0 },
                    { "bump_type", "d", 0 },
                    { "cache_gc", "7200", 0 },
                    { "captcha_gd", "0", 0 },
                    { "captcha_gd_3d_noise", "1", 0 },
                    { "captcha_gd_fonts", "1", 0 },
                    { "captcha_gd_foreground_noise", "0", 0 },
                    { "captcha_gd_wave", "0", 0 },
                    { "captcha_gd_x_grid", "25", 0 },
                    { "captcha_gd_y_grid", "25", 0 },
                    { "captcha_plugin", "core.captcha.plugins.nogd", 0 },
                    { "check_attachment_content", "1", 0 },
                    { "check_dnsbl", "0", 0 },
                    { "chg_passforce", "0", 0 },
                    { "confirm_refresh", "1", 0 },
                    { "contact_admin_form_enable", "1", 0 },
                    { "cookie_domain", "", 0 },
                    { "cookie_name", "phpbb3", 0 },
                    { "cookie_notice", "0", 0 },
                    { "cookie_path", "/", 0 },
                    { "cookie_secure", "0", 0 },
                    { "coppa_enable", "0", 0 },
                    { "coppa_fax", "", 0 },
                    { "coppa_mail", "", 0 },
                    { "database_gc", "604800", 0 },
                    { "dbms_version", "", 0 },
                    { "default_dateformat", "D M d, Y g:i a", 0 },
                    { "default_search_return_chars", "300", 0 },
                    { "default_style", "1", 0 },
                    { "delete_time", "0", 0 },
                    { "display_last_edited", "1", 0 },
                    { "display_last_subject", "1", 0 },
                    { "display_order", "0", 0 },
                    { "display_unapproved_posts", "1", 0 },
                    { "edit_time", "0", 0 },
                    { "email_check_mx", "1", 0 },
                    { "email_enable", "1", 0 },
                    { "email_force_sender", "0", 0 },
                    { "email_max_chunk_size", "50", 0 },
                    { "email_package_size", "20", 0 },
                    { "enable_accurate_pm_button", "1", 0 },
                    { "enable_confirm", "1", 0 },
                    { "enable_mod_rewrite", "0", 0 },
                    { "enable_pm_icons", "1", 0 },
                    { "enable_post_confirm", "1", 0 },
                    { "enable_queue_trigger", "0", 0 },
                    { "enable_update_hashes", "1", 0 },
                    { "extension_force_unstable", "0", 0 },
                    { "feed_enable", "1", 0 },
                    { "feed_forum", "1", 0 },
                    { "feed_http_auth", "0", 0 },
                    { "feed_item_statistics", "1", 0 },
                    { "feed_limit", "10", 0 },
                    { "feed_limit_post", "15", 0 },
                    { "feed_limit_topic", "10", 0 },
                    { "feed_overall", "1", 0 },
                    { "feed_overall_forums", "0", 0 },
                    { "feed_overall_forums_limit", "15", 0 },
                    { "feed_overall_topics", "0", 0 },
                    { "feed_overall_topics_limit", "15", 0 },
                    { "feed_topic", "1", 0 },
                    { "feed_topics_active", "0", 0 },
                    { "feed_topics_new", "1", 0 },
                    { "flood_interval", "15", 0 },
                    { "force_server_vars", "0", 0 },
                    { "form_token_lifetime", "7200", 0 },
                    { "form_token_mintime", "0", 0 },
                    { "form_token_sid_guests", "1", 0 },
                    { "forward_pm", "1", 0 },
                    { "forwarded_for_check", "0", 0 },
                    { "full_folder_action", "2", 0 },
                    { "fulltext_mysql_max_word_len", "254", 0 },
                    { "fulltext_mysql_min_word_len", "4", 0 },
                    { "fulltext_native_common_thres", "5", 0 },
                    { "fulltext_native_load_upd", "1", 0 },
                    { "fulltext_native_max_chars", "14", 0 },
                    { "fulltext_native_min_chars", "3", 0 },
                    { "fulltext_postgres_max_word_len", "254", 0 },
                    { "fulltext_postgres_min_word_len", "4", 0 },
                    { "fulltext_postgres_ts_name", "simple", 0 },
                    { "fulltext_sphinx_indexer_mem_limit", "512", 0 },
                    { "fulltext_sphinx_stopwords", "0", 0 },
                    { "gzip_compress", "0", 0 },
                    { "help_send_statistics", "1", 0 },
                    { "help_send_statistics_time", "0", 0 },
                    { "hot_threshold", "25", 0 },
                    { "icons_path", "images/icons", 0 },
                    { "img_create_thumbnail", "0", 0 },
                    { "img_display_inlined", "1", 0 },
                    { "img_link_height", "0", 0 },
                    { "img_link_width", "0", 0 },
                    { "img_max_height", "0", 0 },
                    { "img_max_thumb_width", "400", 0 },
                    { "img_max_width", "0", 0 },
                    { "img_min_thumb_filesize", "12000", 0 },
                    { "img_quality", "85", 0 },
                    { "img_strip_metadata", "0", 0 },
                    { "ip_check", "3", 0 },
                    { "ip_login_limit_max", "50", 0 },
                    { "ip_login_limit_time", "21600", 0 },
                    { "ip_login_limit_use_forwarded", "0", 0 },
                    { "jab_allow_self_signed", "0", 0 },
                    { "jab_enable", "0", 0 },
                    { "jab_host", "", 0 },
                    { "jab_package_size", "20", 0 },
                    { "jab_password", "", 0 },
                    { "jab_port", "5222", 0 },
                    { "jab_use_ssl", "0", 0 },
                    { "jab_username", "", 0 },
                    { "jab_verify_peer", "1", 0 },
                    { "jab_verify_peer_name", "1", 0 },
                    { "ldap_base_dn", "", 0 },
                    { "ldap_email", "", 0 },
                    { "ldap_password", "", 0 },
                    { "ldap_port", "", 0 },
                    { "ldap_server", "", 0 },
                    { "ldap_uid", "", 0 },
                    { "ldap_user", "", 0 },
                    { "ldap_user_filter", "", 0 },
                    { "legend_sort_groupname", "0", 0 },
                    { "limit_load", "0", 0 },
                    { "limit_search_load", "0", 0 },
                    { "load_anon_lastread", "0", 0 },
                    { "load_birthdays", "1", 0 },
                    { "load_cpf_memberlist", "1", 0 },
                    { "load_cpf_pm", "1", 0 },
                    { "load_cpf_viewprofile", "1", 0 },
                    { "load_cpf_viewtopic", "1", 0 },
                    { "load_db_lastread", "1", 0 },
                    { "load_db_track", "1", 0 },
                    { "load_font_awesome_url", "https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", 0 },
                    { "load_jquery_url", "//ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js", 0 },
                    { "load_jumpbox", "1", 0 },
                    { "load_moderators", "1", 0 },
                    { "load_notifications", "1", 0 },
                    { "load_online", "1", 0 },
                    { "load_online_guests", "1", 0 },
                    { "load_online_time", "5", 0 },
                    { "load_onlinetrack", "1", 0 },
                    { "load_search", "1", 0 },
                    { "load_tplcompile", "0", 0 },
                    { "load_unreads_search", "1", 0 },
                    { "load_user_activity", "1", 0 },
                    { "load_user_activity_limit", "5000", 0 },
                    { "max_attachments", "3", 0 },
                    { "max_attachments_pm", "1", 0 },
                    { "max_autologin_time", "0", 0 },
                    { "max_filesize", "262144", 0 },
                    { "max_filesize_pm", "262144", 0 },
                    { "max_login_attempts", "3", 0 },
                    { "max_name_chars", "20", 0 },
                    { "max_num_search_keywords", "10", 0 },
                    { "max_poll_options", "10", 0 },
                    { "max_post_chars", "60000", 0 },
                    { "max_post_font_size", "200", 0 },
                    { "max_post_img_height", "0", 0 },
                    { "max_post_img_width", "0", 0 },
                    { "max_post_smilies", "0", 0 },
                    { "max_post_urls", "0", 0 },
                    { "max_quote_depth", "3", 0 },
                    { "max_reg_attempts", "5", 0 },
                    { "max_sig_chars", "255", 0 },
                    { "max_sig_font_size", "200", 0 },
                    { "max_sig_img_height", "0", 0 },
                    { "max_sig_img_width", "0", 0 },
                    { "max_sig_smilies", "0", 0 },
                    { "max_sig_urls", "5", 0 },
                    { "mime_triggers", "body|head|html|img|plaintext|a href|pre|script|table|title", 0 },
                    { "min_name_chars", "3", 0 },
                    { "min_pass_chars", "6", 0 },
                    { "min_post_chars", "1", 0 },
                    { "min_search_author_chars", "3", 0 },
                    { "new_member_group_default", "0", 0 },
                    { "new_member_post_limit", "3", 0 },
                    { "override_user_style", "0", 0 },
                    { "pass_complex", "PASS_TYPE_ANY", 0 },
                    { "plupload_salt", "phpbb_plupload", 0 },
                    { "pm_edit_time", "0", 0 },
                    { "pm_max_boxes", "4", 0 },
                    { "pm_max_msgs", "50", 0 },
                    { "pm_max_recipients", "0", 0 },
                    { "posts_per_page", "10", 0 },
                    { "print_pm", "1", 0 },
                    { "queue_interval", "60", 0 },
                    { "queue_trigger_posts", "3", 0 },
                    { "ranks_path", "images/ranks", 0 },
                    { "read_notification_expire_days", "30", 0 },
                    { "read_notification_gc", "86400", 0 },
                    { "recaptcha_v3_domain", "google.com", 0 },
                    { "recaptcha_v3_key", "", 0 },
                    { "recaptcha_v3_method", "post", 0 },
                    { "recaptcha_v3_secret", "", 0 },
                    { "recaptcha_v3_threshold_default", "0.5", 0 },
                    { "recaptcha_v3_threshold_login", "0.5", 0 },
                    { "recaptcha_v3_threshold_post", "0.5", 0 },
                    { "recaptcha_v3_threshold_register", "0.5", 0 },
                    { "recaptcha_v3_threshold_report", "0.5", 0 },
                    { "referer_validation", "1", 0 },
                    { "remote_upload_verify", "0", 0 },
                    { "require_activation", "0", 0 },
                    { "script_path", "", 0 },
                    { "search_anonymous_interval", "0", 0 },
                    { "search_block_size", "250", 0 },
                    { "search_gc", "7200", 0 },
                    { "search_interval", "0", 0 },
                    { "search_store_results", "1800", 0 },
                    { "search_type", @"\phpbb\search\fulltext_native", 0 },
                    { "secure_allow_deny", "1", 0 },
                    { "secure_allow_empty_referer", "1", 0 },
                    { "secure_downloads", "0", 0 },
                    { "server_name", "", 0 },
                    { "server_port", "", 0 },
                    { "server_protocol", "", 0 },
                    { "session_gc", "3600", 0 },
                    { "session_length", "3600", 0 },
                    { "site_desc", "{L_CONFIG_SITE_DESC}", 0 },
                    { "site_home_text", "", 0 },
                    { "site_home_url", "", 0 },
                    { "sitename", "{L_CONFIG_SITENAME}", 0 },
                    { "smilies_path", "images/smilies", 0 },
                    { "smilies_per_page", "50", 0 },
                    { "smtp_allow_self_signed", "0", 0 },
                    { "smtp_auth_method", "PLAIN", 0 },
                    { "smtp_delivery", "0", 0 },
                    { "smtp_host", "", 0 },
                    { "smtp_port", "25", 0 },
                    { "smtp_verify_peer", "1", 0 },
                    { "smtp_verify_peer_name", "1", 0 },
                    { "teampage_forums", "1", 0 },
                    { "teampage_memberships", "1", 0 },
                    { "text_reparser.pm_text_cron_interval", "10", 0 },
                    { "text_reparser.pm_text_last_cron", "0", 0 },
                    { "text_reparser.poll_option_cron_interval", "10", 0 },
                    { "text_reparser.poll_option_last_cron", "0", 0 },
                    { "text_reparser.poll_title_cron_interval", "10", 0 },
                    { "text_reparser.poll_title_last_cron", "0", 0 },
                    { "text_reparser.post_text_cron_interval", "10", 0 },
                    { "text_reparser.post_text_last_cron", "0", 0 },
                    { "text_reparser.user_signature_cron_interval", "10", 0 },
                    { "text_reparser.user_signature_last_cron", "0", 0 },
                    { "topics_per_page", "25", 0 },
                    { "tpl_allow_php", "0", 0 },
                    { "update_hashes_last_cron", "0", 0 },
                    { "update_hashes_lock", "0", 0 },
                    { "upload_icons_path", "images/upload_icons", 0 },
                    { "upload_path", "files", 0 },
                    { "use_system_cron", "0", 0 },
                    { "version", "3.3.13", 0 },
                    { "warnings_expire_days", "90", 0 },
                    { "warnings_gc", "14400", 0 }
                });

            migrationBuilder.InsertData(
                table: "ForumConfig",
                columnTypes: new[] { "nvarchar(255)", "nvarchar(255)", "tinyint" },
                columns: new[] { "ConfigName", "ConfigValue", "IsDynamic" },
                values: new object[,]
                {
                    { "cache_last_gc", "0", 1 },
                    { "cron_lock", "0", 1 },
                    { "database_last_gc", "0", 1 },
                    { "last_queue_run", "0", 1 },
                    { "newest_user_colour", "AA0000", 1 },
                    { "newest_user_id", "2", 1 },
                    { "newest_username", "", 1 },
                    { "num_files", "0", 1 },
                    { "num_posts", "1", 1 },
                    { "num_topics", "1", 1 },
                    { "num_users", "1", 1 },
                    { "plupload_last_gc", "0", 1 },
                    { "rand_seed", "0", 1 },
                    { "rand_seed_last_update", "0", 1 },
                    { "read_notification_last_gc", "0", 1 },
                    { "record_online_date", "0", 1 },
                    { "record_online_users", "0", 1 },
                    { "reparse_lock", "0", 1 },
                    { "search_indexing_state", "", 1 },
                    { "search_last_gc", "0", 1 },
                    { "session_last_gc", "0", 1 },
                    { "smtp_password", "", 1 },
                    { "smtp_username", "", 1 },
                    { "upload_dir_size", "0", 1 },
                    { "warnings_last_gc", "0", 1 }
                });

            migrationBuilder.InsertData(
                table: "ForumConfigText",
                columnTypes: new[] { "nvarchar(255)", "text" },
                columns: new[] { "ConfigName", "ConfigValue" },
                values: new object[,]
                {
                    { "contact_admin_info", "" },
                    { "contact_admin_info_uid", "" },
                    { "contact_admin_info_bitfield", "" },
                    { "contact_admin_info_flags", "7" }
                });

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

            migrationBuilder.InsertData(
                table: "ForumStyle",
                columnTypes: new[] { "varchar(255)", "varchar(255)", "tinyint", "varchar(100)", "varchar(255)", "int", "text" },
                columns: new[] { "StyleName", "StyleCopyright", "StyleActive", "StylePath", "BbcodeBitField", "StyleParentId", "StyleParentTree" },
                values: new object[,]
                {
                    { "prosilver", "&copy; phpBB Limited", 1, "prosilver", "//g=", 0, "" }
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
                        "{L_FORUMS_FIRST_CATEGORY}", "", 1, 4, 0, 0,
                        0, 0, 0, 0, 0, 0, 1, 2, "Admin", "AA0000", null, 972086460,
                        "", "", "", "", "", "", "", null, 0, 0, "", null
                    },
                    {
                        "{L_FORUMS_TEST_FORUM_TITLE}", "{L_FORUMS_TEST_FORUM_DESC}", 2, 3, 1, 1,
                        1, 0, 0, 1, 0, 0, 1, 2, "Admin", "AA0000", "{L_TOPICS_TOPIC_TITLE}", 972086460,
                        "", "", "", "", "", "", "", 1, 7, 7, "", 48
                    }
                });

            // Create password hasher
            var hasher = new PasswordHasher<IdentityUser>();

            // Generate unique values
            var userId = Guid.NewGuid().ToString();
            var securityStamp = Guid.NewGuid().ToString();
            var concurrencyStamp = Guid.NewGuid().ToString();

            // Create admin user
            var user = new
            {
                Id = userId,
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
            userId = Guid.NewGuid().ToString();
            securityStamp = Guid.NewGuid().ToString();
            concurrencyStamp = Guid.NewGuid().ToString();
            var stringHelper = new StringHelper();
            var passAnonymous = stringHelper.GenerateRandomPassword();

            // Create anonymous user
            user = new
            {
                Id = userId,
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
                columnTypes: new[] { "nvarchar(450)", "nvarchar(256)", "nvarchar(256)", "nvarchar(256)",
                                     "nvarchar(256)", "bit", "nvarchar(max)", "nvarchar(max)", "nvarchar(max)",
                                     "nvarchar(max)", "bit", "bit", "datetimeoffset", "bit", "int" },
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
                    "UserType", "GroupId", "UserName", "UserNameClean", "UserRegdate",
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
                        2, 1, "Anonymous", "anonymous", 0,
                        "", "en", 1, 0, "",
                        0, "", "", "",
                        "", "", "t",
                        "a", "t", "d",
                        "", "", "", "",
                        "", 0, "", 0
                    },
                    {
                        // Admin user
                        3, 5, "Admin", "admin", 0,
                        "admin@yourdomain.com", "en", 1, 1, "AA0000",
                        1, "", "", "",
                        "", "", "t",
                        "a", "t", "d",
                        "", "", "", "",
                        "", 0, "", null
                    }
                });

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
                        "{L_RANKS_SITE_ADMIN_TITLE}",  // Site Admin rank title
                        0,                             // Minimum posts
                        1,                             // Special rank
                        ""                             // No rank image
                    }
                });

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
                    "{L_TOPICS_TopicTitle}",  // TopicTitle
                    2,                        // TopicPoster
                    972086460,               // TopicTime
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
                    "{L_TOPICS_TopicTitle}",  // TopicLastPostSubject
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
                    "{L_TOPICS_TopicTitle}",                        // PostSubject
                    "{L_DEFAULT_INSTALL_POST}",                     // PostText
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

            var smilies = new[]
            {
                // Very Happy
                new { Code = ":D", Url = "icon_e_biggrin.gif", Emotion = "{L_SMILIES_VERY_HAPPY}", Width = 15, Height = 17, Order = 1 },
                new { Code = ":-D", Url = "icon_e_biggrin.gif", Emotion = "{L_SMILIES_VERY_HAPPY}", Width = 15, Height = 17, Order = 2 },
                new { Code = ":grin:", Url = "icon_e_biggrin.gif", Emotion = "{L_SMILIES_VERY_HAPPY}", Width = 15, Height = 17, Order = 3 },
            
                // Smile
                new { Code = ":)", Url = "icon_e_smile.gif", Emotion = "{L_SMILIES_SMILE}", Width = 15, Height = 17, Order = 4 },
                new { Code = ":-)", Url = "icon_e_smile.gif", Emotion = "{L_SMILIES_SMILE}", Width = 15, Height = 17, Order = 5 },
                new { Code = ":smile:", Url = "icon_e_smile.gif", Emotion = "{L_SMILIES_SMILE}", Width = 15, Height = 17, Order = 6 },
            
                // Wink
                new { Code = ";)", Url = "icon_e_wink.gif", Emotion = "{L_SMILIES_WINK}", Width = 15, Height = 17, Order = 7 },
                new { Code = ";-)", Url = "icon_e_wink.gif", Emotion = "{L_SMILIES_WINK}", Width = 15, Height = 17, Order = 8 },
                new { Code = ":wink:", Url = "icon_e_wink.gif", Emotion = "{L_SMILIES_WINK}", Width = 15, Height = 17, Order = 9 },
            
                // Sad
                new { Code = ":(", Url = "icon_e_sad.gif", Emotion = "{L_SMILIES_SAD}", Width = 15, Height = 17, Order = 10 },
                new { Code = ":-(", Url = "icon_e_sad.gif", Emotion = "{L_SMILIES_SAD}", Width = 15, Height = 17, Order = 11 },
                new { Code = ":sad:", Url = "icon_e_sad.gif", Emotion = "{L_SMILIES_SAD}", Width = 15, Height = 17, Order = 12 },
            
                // Surprised
                new { Code = ":o", Url = "icon_e_surprised.gif", Emotion = "{L_SMILIES_SURPRISED}", Width = 15, Height = 17, Order = 13 },
                new { Code = ":-o", Url = "icon_e_surprised.gif", Emotion = "{L_SMILIES_SURPRISED}", Width = 15, Height = 17, Order = 14 },
                new { Code = ":eek:", Url = "icon_e_surprised.gif", Emotion = "{L_SMILIES_SURPRISED}", Width = 15, Height = 17, Order = 15 },
            
                // Shocked
                new { Code = ":shock:", Url = "icon_eek.gif", Emotion = "{L_SMILIES_SHOCKED}", Width = 15, Height = 17, Order = 16 },
            
                // Confused
                new { Code = ":?", Url = "icon_e_confused.gif", Emotion = "{L_SMILIES_CONFUSED}", Width = 15, Height = 17, Order = 17 },
                new { Code = ":-?", Url = "icon_e_confused.gif", Emotion = "{L_SMILIES_CONFUSED}", Width = 15, Height = 17, Order = 18 },
                new { Code = ":???:", Url = "icon_e_confused.gif", Emotion = "{L_SMILIES_CONFUSED}", Width = 15, Height = 17, Order = 19 },
            
                // Cool
                new { Code = "8-)", Url = "icon_cool.gif", Emotion = "{L_SMILIES_COOL}", Width = 15, Height = 17, Order = 20 },
                new { Code = ":cool:", Url = "icon_cool.gif", Emotion = "{L_SMILIES_COOL}", Width = 15, Height = 17, Order = 21 },
            
                // Laughing
                new { Code = ":lol:", Url = "icon_lol.gif", Emotion = "{L_SMILIES_LAUGHING}", Width = 15, Height = 17, Order = 22 },
            
                // Mad
                new { Code = ":x", Url = "icon_mad.gif", Emotion = "{L_SMILIES_MAD}", Width = 15, Height = 17, Order = 23 },
                new { Code = ":-x", Url = "icon_mad.gif", Emotion = "{L_SMILIES_MAD}", Width = 15, Height = 17, Order = 24 },
                new { Code = ":mad:", Url = "icon_mad.gif", Emotion = "{L_SMILIES_MAD}", Width = 15, Height = 17, Order = 25 },
            
                // Razz
                new { Code = ":P", Url = "icon_razz.gif", Emotion = "{L_SMILIES_RAZZ}", Width = 15, Height = 17, Order = 26 },
                new { Code = ":-P", Url = "icon_razz.gif", Emotion = "{L_SMILIES_RAZZ}", Width = 15, Height = 17, Order = 27 },
                new { Code = ":razz:", Url = "icon_razz.gif", Emotion = "{L_SMILIES_RAZZ}", Width = 15, Height = 17, Order = 28 },
            
                // Embarrassed
                new { Code = ":oops:", Url = "icon_redface.gif", Emotion = "{L_SMILIES_EMARRASSED}", Width = 15, Height = 17, Order = 29 },
            
                // Crying
                new { Code = ":cry:", Url = "icon_cry.gif", Emotion = "{L_SMILIES_CRYING}", Width = 15, Height = 17, Order = 30 },
            
                // Evil
                new { Code = ":evil:", Url = "icon_evil.gif", Emotion = "{L_SMILIES_EVIL}", Width = 15, Height = 17, Order = 31 },
                new { Code = ":twisted:", Url = "icon_twisted.gif", Emotion = "{L_SMILIES_TWISTED_EVIL}", Width = 15, Height = 17, Order = 32 },
            
                // Rolling Eyes
                new { Code = ":roll:", Url = "icon_rolleyes.gif", Emotion = "{L_SMILIES_ROLLING_EYES}", Width = 15, Height = 17, Order = 33 },
            
                // Special
                new { Code = ":!:", Url = "icon_exclaim.gif", Emotion = "{L_SMILIES_EXCLAMATION}", Width = 15, Height = 17, Order = 34 },
                new { Code = ":?:", Url = "icon_question.gif", Emotion = "{L_SMILIES_QUESTION}", Width = 15, Height = 17, Order = 35 },
                new { Code = ":idea:", Url = "IconIdea.gif", Emotion = "{L_SMILIES_IDEA}", Width = 15, Height = 17, Order = 36 },
                new { Code = ":arrow:", Url = "icon_arrow.gif", Emotion = "{L_SMILIES_ARROW}", Width = 15, Height = 17, Order = 37 },
            
                // Neutral
                new { Code = ":|", Url = "icon_neutral.gif", Emotion = "{L_SMILIES_NEUTRAL}", Width = 15, Height = 17, Order = 38 },
                new { Code = ":-|", Url = "icon_neutral.gif", Emotion = "{L_SMILIES_NEUTRAL}", Width = 15, Height = 17, Order = 39 },
            
                // Mr Green
                new { Code = ":mrgreen:", Url = "icon_mrgreen.gif", Emotion = "{L_SMILIES_MR_GREEN}", Width = 15, Height = 17, Order = 40 },
            
                // Geek
                new { Code = ":geek:", Url = "icon_e_geek.gif", Emotion = "{L_SMILIES_GEEK}", Width = 17, Height = 17, Order = 41 },
                new { Code = ":ugeek:", Url = "icon_e_ugeek.gif", Emotion = "{L_SMILIES_UBER_GEEK}", Width = 17, Height = 18, Order = 42 }
            };

            foreach (var smilie in smilies)
            {
                migrationBuilder.InsertData(
                    table: "ForumSmilie",
                    columnTypes: new[] {
                        "varchar(50)",  // Code
                        "varchar(50)",  // SmileyUrl
                        "varchar(255)", // Emotion
                        "smallint",     // SmileyWidth
                        "smallint",     // SmileyHeight
                        "bigint"        // SmileyOrder
                    },
                    columns: new[] { "Code", "SmileyUrl", "Emotion", "SmileyWidth", "SmileyHeight", "SmileyOrder" },
                    values: new object[] { smilie.Code, smilie.Url, smilie.Emotion, smilie.Width, smilie.Height, smilie.Order });
            }

            var icons = new[]
            {
                // Misc Icons
                new { Url = "misc/fire.gif", Width = 16, Height = 16, Order = 1, Display = true },
                new { Url = "misc/star.gif", Width = 16, Height = 16, Order = 2, Display = true },
                new { Url = "misc/radioactive.gif", Width = 16, Height = 16, Order = 3, Display = true },
                new { Url = "misc/heart.gif", Width = 16, Height = 16, Order = 4, Display = true },
                new { Url = "misc/thinking.gif", Width = 16, Height = 16, Order = 5, Display = true },
            
                // Smile Icons
                new { Url = "smile/question.gif", Width = 16, Height = 16, Order = 6, Display = true },
                new { Url = "smile/alert.gif", Width = 16, Height = 16, Order = 7, Display = true },
                new { Url = "smile/info.gif", Width = 16, Height = 16, Order = 8, Display = true },
                new { Url = "smile/redface.gif", Width = 16, Height = 16, Order = 9, Display = true },
                new { Url = "smile/mrgreen.gif", Width = 16, Height = 16, Order = 10, Display = true }
            };

            foreach (var icon in icons)
            {
                migrationBuilder.InsertData(
                    table: "ForumIcon",
                    columnTypes: new[] {
                        "varchar(255)", // IconsUrl
                        "tinyint",      // IconsWidth
                        "tinyint",      // IconsHeight
                        "bigint",       // IconsOrder
                        "tinyint"       // DisplayOnPosting
                    },
                    columns: new[]
                    {
                    "IconsUrl",
                    "IconsWidth",
                    "IconsHeight",
                    "IconsOrder",
                    "DisplayOnPosting"
                    },
                    values: new object[]
                    {
                    icon.Url,
                    icon.Width,
                    icon.Height,
                    icon.Order,
                    icon.Display ? 1 : 0
                    });
            }

            var reasons = new[]
            {
                new
                {
                    Title = "warez",
                    Description = "{L_REPORT_WAREZ}",
                    Order = 1
                },
                new
                {
                    Title = "spam",
                    Description = "{L_REPORT_SPAM}",
                    Order = 2
                },
                new
                {
                    Title = "off_topic",
                    Description = "{L_REPORT_OFF_TOPIC}",
                    Order = 3
                },
                new
                {
                    Title = "other",
                    Description = "{L_REPORT_OTHER}",
                    Order = 4
                }
            };

            foreach (var reason in reasons)
            {
                migrationBuilder.InsertData(
                    table: "ForumReportsReason",
                    columnTypes: new[] {
                        "varchar(255)", // ReasonTitle
                        "text",         // ReasonDescription
                        "smallint"      // ReasonOrder
                    },
                    columns: new[]
                    {
                    "ReasonTitle",
                    "ReasonDescription",
                    "ReasonOrder"
                    },
                    values: new object[]
                    {
                    reason.Title,
                    reason.Description,
                    reason.Order
                    });
            }

            var extensionGroups = new[]
            {
                new
                {
                    Name = "IMAGES",
                    Category = 1,
                    Allow = true,
                    Download = 1,
                    Icon = "",
                    MaxSize = 0,
                    Forums = ""
                },
                new
                {
                    Name = "ARCHIVES",
                    Category = 0,
                    Allow = true,
                    Download = 1,
                    Icon = "",
                    MaxSize = 0,
                    Forums = ""
                },
                new
                {
                    Name = "PLAIN_TEXT",
                    Category = 0,
                    Allow = false,
                    Download = 1,
                    Icon = "",
                    MaxSize = 0,
                    Forums = ""
                },
                new
                {
                    Name = "DOCUMENTS",
                    Category = 0,
                    Allow = false,
                    Download = 1,
                    Icon = "",
                    MaxSize = 0,
                    Forums = ""
                },
                new
                {
                    Name = "DOWNLOADABLE_FILES",
                    Category = 0,
                    Allow = false,
                    Download = 1,
                    Icon = "",
                    MaxSize = 0,
                    Forums = ""
                }
            };

            foreach (var group in extensionGroups)
            {
                migrationBuilder.InsertData(
                    table: "ForumExtensionGroup",
                    columnTypes: new[] {
                        "varchar(255)",     // GroupName
                        "tinyint",          // CatId
                        "tinyint",          // AllowGroup
                        "tinyint",          // DownloadMode
                        "varchar(255)",     // UploadIcon
                        "int",              // MaxFileSize
                        "text"              // AllowedForums
                    },
                    columns: new[]
                    {
                    "GroupName",
                    "CatId",
                    "AllowGroup",
                    "DownloadMode",
                    "UploadIcon",
                    "MaxFileSize",
                    "AllowedForums"
                    },
                    values: new object[]
                    {
                    group.Name,
                    group.Category,
                    group.Allow ? 1 : 0,
                    group.Download,
                    group.Icon,
                    group.MaxSize,
                    group.Forums
                    });
            }

            var extensions = new[]
            {
                // Group 1 - Images
                new { GroupId = 1, Ext = "gif" },
                new { GroupId = 1, Ext = "png" },
                new { GroupId = 1, Ext = "jpeg" },
                new { GroupId = 1, Ext = "jpg" },
                new { GroupId = 1, Ext = "tif" },
                new { GroupId = 1, Ext = "tiff" },
                new { GroupId = 1, Ext = "tga" },

                // Group 2 - Archives
                new { GroupId = 2, Ext = "gtar" },
                new { GroupId = 2, Ext = "gz" },
                new { GroupId = 2, Ext = "tar" },
                new { GroupId = 2, Ext = "zip" },
                new { GroupId = 2, Ext = "rar" },
                new { GroupId = 2, Ext = "ace" },
                new { GroupId = 2, Ext = "torrent" },
                new { GroupId = 2, Ext = "tgz" },
                new { GroupId = 2, Ext = "bz2" },
                new { GroupId = 2, Ext = "7z" },

                // Group 3 - Plain Text
                new { GroupId = 3, Ext = "txt" },
                new { GroupId = 3, Ext = "c" },
                new { GroupId = 3, Ext = "h" },
                new { GroupId = 3, Ext = "cpp" },
                new { GroupId = 3, Ext = "hpp" },
                new { GroupId = 3, Ext = "diz" },
                new { GroupId = 3, Ext = "csv" },
                new { GroupId = 3, Ext = "ini" },
                new { GroupId = 3, Ext = "log" },
                new { GroupId = 3, Ext = "js" },
                new { GroupId = 3, Ext = "xml" },

                // Group 4 - Documents
                new { GroupId = 4, Ext = "xls" },
                new { GroupId = 4, Ext = "xlsx" },
                new { GroupId = 4, Ext = "xlsm" },
                new { GroupId = 4, Ext = "xlsb" },
                new { GroupId = 4, Ext = "doc" },
                new { GroupId = 4, Ext = "docx" },
                new { GroupId = 4, Ext = "docm" },
                new { GroupId = 4, Ext = "dot" },
                new { GroupId = 4, Ext = "dotx" },
                new { GroupId = 4, Ext = "dotm" },
                new { GroupId = 4, Ext = "pdf" },
                new { GroupId = 4, Ext = "ai" },
                new { GroupId = 4, Ext = "ps" },
                new { GroupId = 4, Ext = "ppt" },
                new { GroupId = 4, Ext = "pptx" },
                new { GroupId = 4, Ext = "pptm" },
                new { GroupId = 4, Ext = "odg" },
                new { GroupId = 4, Ext = "odp" },
                new { GroupId = 4, Ext = "ods" },
                new { GroupId = 4, Ext = "odt" },
                new { GroupId = 4, Ext = "rtf" },

                // Group 5 - Downloadable Files
                new { GroupId = 5, Ext = "mp3" },
                new { GroupId = 5, Ext = "mpeg" },
                new { GroupId = 5, Ext = "mpg" },
                new { GroupId = 5, Ext = "ogg" },
                new { GroupId = 5, Ext = "ogm" }
            };

            foreach (var ext in extensions)
            {
                migrationBuilder.InsertData(
                    table: "ForumExtension",
                    columnTypes: new[] { "bigint", "varchar(100)" },
                    columns: new[]
                    {
                    "GroupId",
                    "Extension"
                    },
                    values: new object[]
                    {
                    ext.GroupId,
                    ext.Ext
                    });
            }

            var profileFields = new[]
            {
                // Location
                new
                {
                    Name = "Forumlocation",
                    Type = "profilefields.type.string",
                    Ident = "Forumlocation",
                    Length = "20",
                    Minlen = 2,
                    Maxlen = 100,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 1,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },
            
                // Website
                new
                {
                    Name = "Forumwebsite",
                    Type = "profilefields.type.url",
                    Ident = "Forumwebsite",
                    Length = "40",
                    Minlen = 12,
                    Maxlen = 255,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 2,
                    IsContact = true,
                    ContactDesc = "VISIT_WEBSITE",
                    ContactUrl = "%s"
                },
            
                // Interests
                new
                {
                    Name = "Foruminterests",
                    Type = "profilefields.type.text",
                    Ident = "Foruminterests",
                    Length = "3|30",
                    Minlen = 2,
                    Maxlen = 500,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = false,
                    ShowOnVt = false,
                    ShowOnMl = false,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 3,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },
            
                // Occupation
                new
                {
                    Name = "Forumoccupation",
                    Type = "profilefields.type.text",
                    Ident = "Forumoccupation",
                    Length = "3|30",
                    Minlen = 2,
                    Maxlen = 500,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = false,
                    ShowOnVt = false,
                    ShowOnMl = false,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 4,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },
            
                // ICQ
                new
                {
                    Name = "Forumicq",
                    Type = "profilefields.type.string",
                    Ident = "Forumicq",
                    Length = "20",
                    Minlen = 3,
                    Maxlen = 15,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[0-9]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 6,
                    IsContact = true,
                    ContactDesc = "SEND_ICQ_MESSAGE",
                    ContactUrl = "https://www.icq.com/people/%s/"
                },
            
                // Yahoo
                new
                {
                    Name = "Forumyahoo",
                    Type = "profilefields.type.string",
                    Ident = "Forumyahoo",
                    Length = "40",
                    Minlen = 5,
                    Maxlen = 255,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 8,
                    IsContact = true,
                    ContactDesc = "SEND_YIM_MESSAGE",
                    ContactUrl = "ymsgr:sendim?%s"
                },
            
                // Facebook
                new
                {
                    Name = "Forumfacebook",
                    Type = "profilefields.type.string",
                    Ident = "Forumfacebook",
                    Length = "20",
                    Minlen = 5,
                    Maxlen = 50,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[\\w.]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 9,
                    IsContact = true,
                    ContactDesc = "VIEW_FACEBOOK_PROFILE",
                    ContactUrl = "https://facebook.com/%s/"
                },
            
                // Twitter
                new
                {
                    Name = "Forumtwitter",
                    Type = "profilefields.type.string",
                    Ident = "Forumtwitter",
                    Length = "20",
                    Minlen = 1,
                    Maxlen = 15,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[\\w_]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 10,
                    IsContact = true,
                    ContactDesc = "VIEW_TWITTER_PROFILE",
                    ContactUrl = "https://twitter.com/%s"
                },
            
                // Skype
                new
                {
                    Name = "Forumskype",
                    Type = "profilefields.type.string",
                    Ident = "Forumskype",
                    Length = "20",
                    Minlen = 6,
                    Maxlen = 32,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[a-zA-Z][\\w\\.,\\-_]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 11,
                    IsContact = true,
                    ContactDesc = "VIEW_SKYPE_PROFILE",
                    ContactUrl = "skype:%s?userinfo"
                },
            
                // YouTube
                new
                {
                    Name = "Forumyoutube",
                    Type = "profilefields.type.string",
                    Ident = "Forumyoutube",
                    Length = "20",
                    Minlen = 3,
                    Maxlen = 60,
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "(@[a-zA-Z0-9_.-]{3,30}|c/[a-zA-Z][\\w\\.,\\-_]+|(channel|user)/[a-zA-Z][\\w\\.,\\-_]+)",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 12,
                    IsContact = true,
                    ContactDesc = "VIEW_YOUTUBE_PROFILE",
                    ContactUrl = "https://youtube.com/%s"
                }
            };

            foreach (var field in profileFields)
            {
                migrationBuilder.InsertData(
                    table: "ForumProfileField",
                    columnTypes: new[]
                    {
                        "varchar(255)", // FieldName
                        "varchar(100)", // FieldType
                        "varchar(20)",  // FieldIdent
                        "varchar(20)",  // FieldLength
                        "varchar(255)", // FieldMinlen
                        "varchar(255)", // FieldMaxlen
                        "varchar(255)", // FieldNovalue
                        "varchar(255)", // FieldDefaultValue
                        "varchar(128)", // FieldValidation
                        "tinyint",      // FieldRequired
                        "tinyint",      // FieldShowNovalue
                        "tinyint",      // FieldShowOnReg
                        "tinyint",      // FieldShowOnPm
                        "tinyint",      // FieldShowOnVt
                        "tinyint",      // FieldShowOnMl
                        "tinyint",      // FieldShowProfile
                        "tinyint",      // FieldHide
                        "tinyint",      // FieldNoView
                        "tinyint",      // FieldActive
                        "bigint",       // FieldOrder
                        "tinyint",      // FieldIsContact
                        "varchar(255)", // FieldContactDesc
                        "varchar(255)"  // FieldContactUrl
                    },
                    columns: new[]
                    {
                    "FieldName", "FieldType", "FieldIdent", "FieldLength",
                    "FieldMinlen", "FieldMaxlen", "FieldNovalue", "FieldDefaultValue",
                    "FieldValidation", "FieldRequired", "FieldShowNovalue",
                    "FieldShowOnReg", "FieldShowOnPm", "FieldShowOnVt",
                    "FieldShowOnMl", "FieldShowProfile", "FieldHide",
                    "FieldNoView", "FieldActive", "FieldOrder",
                    "FieldIsContact", "FieldContactDesc", "FieldContactUrl"
                    },
                    values: new object[]
                    {
                    field.Name, field.Type, field.Ident, field.Length,
                    field.Minlen, field.Maxlen, field.Novalue, field.DefaultValue,
                    field.Validation, field.Required ? 1 : 0, field.ShowNovalue ? 1 : 0,
                    field.ShowOnReg ? 1 : 0, field.ShowOnPm ? 1 : 0, field.ShowOnVt ? 1 : 0,
                    field.ShowOnMl ? 1 : 0, field.ShowProfile ? 1 : 0, field.Hide ? 1 : 0,
                    field.NoView ? 1 : 0, field.Active ? 1 : 0, field.Order,
                    field.IsContact ? 1 : 0, field.ContactDesc, field.ContactUrl
                    });
            }

            var notifications = new[]
            {
                // Post Notifications
                new
                {
                    Type = "notification.type.post",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.board"
                },
                new
                {
                    Type = "notification.type.post",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.email"
                },
            
                // Topic Notifications
                new
                {
                    Type = "notification.type.topic",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.board"
                },
                new
                {
                    Type = "notification.type.topic",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.email"
                },
            
                // Forum Notifications
                new
                {
                    Type = "notification.type.forum",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.board"
                },
                new
                {
                    Type = "notification.type.forum",
                    ItemId = 0,
                    UserId = 2,
                    Method = "notification.method.email"
                }
            };

            foreach (var notification in notifications)
            {
                migrationBuilder.InsertData(
                    table: "ForumUserNotification",
                    columnTypes: new[] { "varchar(165)", "bigint", "bigint", "varchar(165)" },
                    columns: new[]
                    {
                    "ItemType",
                    "ItemId",
                    "UserId",
                    "Method"
                    },
                    values: new object[]
                    {
                    notification.Type,
                    notification.ItemId,
                    notification.UserId,
                    notification.Method
                    });
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumUserNotification",
                keyColumns: new[] { "UserId", "ItemType" },
                keyValues: new object[] { 2, "notification.type.post" });

            migrationBuilder.DeleteData(
                table: "ForumUserNotification",
                keyColumns: new[] { "UserId", "ItemType" },
                keyValues: new object[] { 2, "notification.type.topic" });

            migrationBuilder.DeleteData(
                table: "ForumUserNotification",
                keyColumns: new[] { "UserId", "ItemType" },
                keyValues: new object[] { 2, "notification.type.forum" });

            migrationBuilder.Sql("DELETE FROM ForumProfileField WHERE FieldOrder BETWEEN 1 AND 12");

            // Remove all extensions for groups 1-5
            migrationBuilder.Sql("DELETE FROM ForumExtension WHERE GroupId BETWEEN 1 AND 5");

            var groupNames = new[] { "IMAGES", "ARCHIVES", "PLAIN_TEXT", "DOCUMENTS", "DOWNLOADABLE_FILES" };
            foreach (var name in groupNames)
            {
                migrationBuilder.DeleteData(
                    table: "ForumExtensionGroup",
                    keyColumn: "GroupName",
                    keyValue: name);
            }

            migrationBuilder.Sql("DELETE FROM ForumReportsReason WHERE ReasonOrder BETWEEN 1 AND 4");

            migrationBuilder.Sql("DELETE FROM ForumIcon WHERE IconsOrder BETWEEN 1 AND 10");

            migrationBuilder.Sql("DELETE FROM ForumSmilie WHERE SmileyOrder BETWEEN 1 AND 42");

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
                migrationBuilder.Sql(@"
            DELETE FROM ForumAclRoleData 
            WHERE RoleId IN (21, 22, 23, 24)");

                // Remove all special access role data
                migrationBuilder.Sql(@"
            DELETE FROM ForumAclRoleData 
            WHERE RoleId IN (18, 19, 20)");

                // Remove all forum access role data
                migrationBuilder.Sql(@"
            DELETE FROM ForumAclRoleData 
            WHERE RoleId IN (14, 15, 16, 17)");

                // Remove all moderator role data
                migrationBuilder.Sql(@"
            DELETE FROM ForumAclRoleData 
            WHERE RoleId IN (10, 11, 12, 13)");

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

                // Delete the test forum first (child)
                migrationBuilder.DeleteData(
                    table: "Forum",
                    keyColumns: new[] { "ForumName", "LeftId", "RightId", "ParentId" },
                    keyValues: new object[] { "{L_FORUMS_TEST_FORUM_TITLE}", 2, 3, 1 });

                // Then delete the category (parent)
                migrationBuilder.DeleteData(
                    table: "Forum",
                    keyColumns: new[] { "ForumName", "LeftId", "RightId", "ParentId" },
                    keyValues: new object[] { "{L_FORUMS_FIRST_CATEGORY}", 1, 4, 0 });

                migrationBuilder.DeleteData(
                    table: "ForumStyle",
                    keyColumn: "StyleName",
                    keyValue: "prosilver");

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

                migrationBuilder.DeleteData(
                    table: "ForumConfigText",
                    keyColumn: "ConfigName",
                    keyValues: new[]
                    {
                    "contact_admin_info",
                    "contact_admin_info_uid",
                    "contact_admin_info_bitfield",
                    "contact_admin_info_flags"
                    });

                migrationBuilder.DeleteData(
                    table: "ForumConfig",
                    keyColumn: "ConfigName",
                    keyValues: new[]
                    {
                    "cache_last_gc",
                    "cron_lock",
                    "database_last_gc",
                    "last_queue_run",
                    "newest_user_colour",
                    "newest_user_id",
                    "newest_username",
                    "num_files",
                    "num_posts",
                    "num_topics",
                    "num_users",
                    "plupload_last_gc",
                    "rand_seed",
                    "rand_seed_last_update",
                    "read_notification_last_gc",
                    "record_online_date",
                    "record_online_users",
                    "reparse_lock",
                    "search_indexing_state",
                    "search_last_gc",
                    "session_last_gc",
                    "smtp_password",
                    "smtp_username",
                    "upload_dir_size",
                    "warnings_last_gc"
                    });

                migrationBuilder.DeleteData(
                    table: "ForumConfig",
                    keyColumn: "ConfigName",
                    keyValues: new[] {
                            "active_sessions",
                            "allow_attachments",
                            "allow_autologin",
                            "allow_avatar",
                            "allow_avatar_gravatar",
                            "allow_avatar_local",
                            "allow_avatar_remote",
                            "allow_avatar_remote_upload",
                            "allow_avatar_upload",
                            "allow_bbcode",
                            "allow_birthdays",
                            "allow_board_notifications",
                            "allow_bookmarks",
                            "allow_cdn",
                            "allow_emailreuse",
                            "allow_forum_notify",
                            "allow_live_searches",
                            "allow_mass_pm",
                            "allow_name_chars",
                            "allow_namechange",
                            "allow_nocensors",
                            "allow_password_reset",
                            "allow_pm_attach",
                            "allow_pm_report",
                            "allow_post_flash",
                            "allow_post_links",
                            "allow_privmsg",
                            "allow_quick_reply",
                            "allow_sig",
                            "allow_sig_bbcode",
                            "allow_sig_flash",
                            "allow_sig_img",
                            "allow_sig_links",
                            "allow_sig_pm",
                            "allow_sig_smilies",
                            "allow_smilies",
                            "allow_topic_notify",
                            "allowed_schemes_links",
                            "assets_version",
                            "attachment_quota",
                            "auth_bbcode_pm",
                            "auth_flash_pm",
                            "auth_img_pm",
                            "auth_method",
                            "auth_smilies_pm",
                            "avatar_filesize",
                            "avatar_gallery_path",
                            "avatar_max_height",
                            "avatar_max_width",
                            "avatar_min_height",
                            "avatar_min_width",
                            "avatar_path",
                            "avatar_salt",
                            "board_contact",
                            "board_contact_name",
                            "board_disable",
                            "board_disable_msg",
                            "board_email",
                            "board_email_form",
                            "board_email_sig",
                            "board_hide_emails",
                            "board_index_text",
                            "board_timezone",
                            "browser_check",
                            "bump_interval",
                            "bump_type",
                            "cache_gc",
                            "captcha_gd",
                            "captcha_gd_3d_noise",
                            "captcha_gd_fonts",
                            "captcha_gd_foreground_noise",
                            "captcha_gd_wave",
                            "captcha_gd_x_grid",
                            "captcha_gd_y_grid",
                            "captcha_plugin",
                            "check_attachment_content",
                            "check_dnsbl",
                            "chg_passforce",
                            "confirm_refresh",
                            "contact_admin_form_enable",
                            "cookie_domain",
                            "cookie_name",
                            "cookie_notice",
                            "cookie_path",
                            "cookie_secure",
                            "coppa_enable",
                            "coppa_fax",
                            "coppa_mail",
                            "database_gc",
                            "dbms_version",
                            "default_dateformat",
                            "default_search_return_chars",
                            "default_style",
                            "delete_time",
                            "display_last_edited",
                            "display_last_subject",
                            "display_order",
                            "display_unapproved_posts",
                            "edit_time",
                            "email_check_mx",
                            "email_enable",
                            "email_force_sender",
                            "email_max_chunk_size",
                            "email_package_size",
                            "enable_accurate_pm_button",
                            "enable_confirm",
                            "enable_mod_rewrite",
                            "enable_pm_icons",
                            "enable_post_confirm",
                            "enable_queue_trigger",
                            "enable_update_hashes",
                            "extension_force_unstable",
                            "feed_enable",
                            "feed_forum",
                            "feed_http_auth",
                            "feed_item_statistics",
                            "feed_limit",
                            "feed_limit_post",
                            "feed_limit_topic",
                            "feed_overall",
                            "feed_overall_forums",
                            "feed_overall_forums_limit",
                            "feed_overall_topics",
                            "feed_overall_topics_limit",
                            "feed_topic",
                            "feed_topics_active",
                            "feed_topics_new",
                            "flood_interval",
                            "force_server_vars",
                            "form_token_lifetime",
                            "form_token_mintime",
                            "form_token_sid_guests",
                            "forward_pm",
                            "forwarded_for_check",
                            "full_folder_action",
                            "fulltext_mysql_max_word_len",
                            "fulltext_mysql_min_word_len",
                            "fulltext_native_common_thres",
                            "fulltext_native_load_upd",
                            "fulltext_native_max_chars",
                            "fulltext_native_min_chars",
                            "fulltext_postgres_max_word_len",
                            "fulltext_postgres_min_word_len",
                            "fulltext_postgres_ts_name",
                            "fulltext_sphinx_indexer_mem_limit",
                            "fulltext_sphinx_stopwords",
                            "gzip_compress",
                            "help_send_statistics",
                            "help_send_statistics_time",
                            "hot_threshold",
                            "icons_path",
                            "img_create_thumbnail",
                            "img_display_inlined",
                            "img_link_height",
                            "img_link_width",
                            "img_max_height",
                            "img_max_thumb_width",
                            "img_max_width",
                            "img_min_thumb_filesize",
                            "img_quality",
                            "img_strip_metadata",
                            "ip_check",
                            "ip_login_limit_max",
                            "ip_login_limit_time",
                            "ip_login_limit_use_forwarded",
                            "jab_allow_self_signed",
                            "jab_enable",
                            "jab_host",
                            "jab_package_size",
                            "jab_password",
                            "jab_port",
                            "jab_use_ssl",
                            "jab_username",
                            "jab_verify_peer",
                            "jab_verify_peer_name",
                            "ldap_base_dn",
                            "ldap_email",
                            "ldap_password",
                            "ldap_port",
                            "ldap_server",
                            "ldap_uid",
                            "ldap_user",
                            "ldap_user_filter",
                            "legend_sort_groupname",
                            "limit_load",
                            "limit_search_load",
                            "load_anon_lastread",
                            "load_birthdays",
                            "load_cpf_memberlist",
                            "load_cpf_pm",
                            "load_cpf_viewprofile",
                            "load_cpf_viewtopic",
                            "load_db_lastread",
                            "load_db_track",
                            "load_font_awesome_url",
                            "load_jquery_url",
                            "load_jumpbox",
                            "load_moderators",
                            "load_notifications",
                            "load_online",
                            "load_online_guests",
                            "load_online_time",
                            "load_onlinetrack",
                            "load_search",
                            "load_tplcompile",
                            "load_unreads_search",
                            "load_user_activity",
                            "load_user_activity_limit",
                            "max_attachments",
                            "max_attachments_pm",
                            "max_autologin_time",
                            "max_filesize",
                            "max_filesize_pm",
                            "max_login_attempts",
                            "max_name_chars",
                            "max_num_search_keywords",
                            "max_poll_options",
                            "max_post_chars",
                            "max_post_font_size",
                            "max_post_img_height",
                            "max_post_img_width",
                            "max_post_smilies",
                            "max_post_urls",
                            "max_quote_depth",
                            "max_reg_attempts",
                            "max_sig_chars",
                            "max_sig_font_size",
                            "max_sig_img_height",
                            "max_sig_img_width",
                            "max_sig_smilies",
                            "max_sig_urls",
                            "mime_triggers",
                            "min_name_chars",
                            "min_pass_chars",
                            "min_post_chars",
                            "min_search_author_chars",
                            "new_member_group_default",
                            "new_member_post_limit",
                            "override_user_style",
                            "pass_complex",
                            "plupload_salt",
                            "pm_edit_time",
                            "pm_max_boxes",
                            "pm_max_msgs",
                            "pm_max_recipients",
                            "posts_per_page",
                            "print_pm",
                            "queue_interval",
                            "queue_trigger_posts",
                            "ranks_path",
                            "read_notification_expire_days",
                            "read_notification_gc",
                            "recaptcha_v3_domain",
                            "recaptcha_v3_key",
                            "recaptcha_v3_method",
                            "recaptcha_v3_secret",
                            "recaptcha_v3_threshold_default",
                            "recaptcha_v3_threshold_login",
                            "recaptcha_v3_threshold_post",
                            "recaptcha_v3_threshold_register",
                            "recaptcha_v3_threshold_report",
                            "referer_validation",
                            "remote_upload_verify",
                            "require_activation",
                            "script_path",
                            "search_anonymous_interval",
                            "search_block_size",
                            "search_gc",
                            "search_interval",
                            "search_store_results",
                            "search_type",
                            "secure_allow_deny",
                            "secure_allow_empty_referer",
                            "secure_downloads",
                            "server_name",
                            "server_port",
                            "server_protocol",
                            "session_gc",
                            "session_length",
                            "site_desc",
                            "site_home_text",
                            "site_home_url",
                            "sitename",
                            "smilies_path",
                            "smilies_per_page",
                            "smtp_allow_self_signed",
                            "smtp_auth_method",
                            "smtp_delivery",
                            "smtp_host",
                            "smtp_port",
                            "smtp_verify_peer",
                            "smtp_verify_peer_name",
                            "teampage_forums",
                            "teampage_memberships",
                            "text_reparser.pm_text_cron_interval",
                            "text_reparser.pm_text_last_cron",
                            "text_reparser.poll_option_cron_interval",
                            "text_reparser.poll_option_last_cron",
                            "text_reparser.poll_title_cron_interval",
                            "text_reparser.poll_title_last_cron",
                            "text_reparser.post_text_cron_interval",
                            "text_reparser.post_text_last_cron",
                            "text_reparser.user_signature_cron_interval",
                            "text_reparser.user_signature_last_cron",
                            "topics_per_page",
                            "tpl_allow_php",
                            "update_hashes_last_cron",
                            "update_hashes_lock",
                            "upload_icons_path",
                            "upload_path",
                            "use_system_cron",
                            "version",
                            "warnings_expire_days",
                            "warnings_gc"
                    });
            }
        }
    }
}
