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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
